using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findAndReplaceControls.Show();
        }

        public async void UpdateDisplay(string path)
        {
            UpdateStatus("Loading...");
            FileOperations.clearFiles();
            display.Text = "";
            if (!Directory.GetDirectories(path).Any())
            {
                await Task.Run(() => { FileOperations.DirSearch(path); });
            }
            else
            {
                await Task.Run(() => { FileOperations.DirSearchRecursive(path); }); ;
            }

            foreach (var info in FileOperations.getFiles())
            {
                if (info != null && info.FileInfo != null && !string.IsNullOrEmpty(info.FileInfo.FullName))
                {
                    display.Text += info.FileInfo.FullName + " \n";
                }
            }
            UpdateStatus("Ready.");
        }

        private void UpdateStatus(string status)
        {
            if (!string.IsNullOrEmpty(status))
            {
                toolStripStatusLabel1.Text = status;
            }
        }

    }
}
