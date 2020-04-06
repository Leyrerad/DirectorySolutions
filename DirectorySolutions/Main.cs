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
        private bool isExpanded = false;
        private string path;

        public Main()
        {
            InitializeComponent();
            findAndReplaceControls.Hide();
            findExtensionControls.Hide();
            findAndReplaceControls.FindReplaceClicked += FindAndReplaceControls_FindReplaceClicked1;
            directorySelectionControls.FilePathChanged += DirectorySelectionControls_FilePathChanged1;
        }

        private void DirectorySelectionControls_FilePathChanged1(object sender, EventArgs e)
        {
            var tempPath = directorySelectionControls.Controls.Find("filePath", true)[0].Text;
            if (Directory.Exists(tempPath))
            {
                path = tempPath;
                UpdateDisplay(path);
            }
        }

        private void FindAndReplaceControls_FindReplaceClicked1(object sender, EventArgs e)
        {
            if (findAndReplaceControls.SetReplacementTexts())
            {
                if (FileOperations.FindAndReplace(FileOperations.getFiles(),
                    findAndReplaceControls.getInText(),
                    findAndReplaceControls.getOutText()))
                {
                    if (Directory.Exists(path))
                    {
                        UpdateDisplay(path);
                    }
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                ExpandOrContractMainForm(647, isExpanded);
            }
            RemoveUnusedUserControls(new List<UserControl>() { directorySelectionControls, findAndReplaceControls });
            findAndReplaceControls.Show();
        }

        public void ExpandOrContractMainForm(int height, bool expanded)
        {
            Size = new Size(1006, height);
            isExpanded = expanded ? false : true;
        }

        private void RemoveUnusedUserControls(List<UserControl> usedControls)
        {
            List<UserControl> allUserControls = new List<UserControl>() { findAndReplaceControls, directorySelectionControls, findExtensionControls };
            foreach(var control in allUserControls)
            {
                if (!usedControls.Contains(control))
                {
                    control.Hide();
                }
            }
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
                if (info != null  && !string.IsNullOrEmpty(info.FullName))
                {
                    display.Text += info.FullName + " \n";
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

        private void findAllExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                ExpandOrContractMainForm(647, isExpanded);
            }

            RemoveUnusedUserControls(new List<UserControl>() { directorySelectionControls, findExtensionControls });
            findExtensionControls.Show();
        }
    }
}
