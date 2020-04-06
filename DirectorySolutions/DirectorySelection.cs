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
    public partial class DirectorySelection : UserControl
    {
        private List<FileInformation> Files;
        public event EventHandler FilePathChanged;
        public DirectorySelection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="select your directory path." })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var path = e.Url.ToString().Replace("file:///", "").Replace("file://","");
            filePath.Text = path;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        protected virtual void OnFilePathTextChanged(EventArgs e)
        {
            var handler = FilePathChanged;
            if (handler != null)
                handler(this, e);
        }

        private void filePath_TextChanged(object sender, EventArgs e)
        {
            OnFilePathTextChanged(e);
        }

        //private void btnFileImport_Click(object sender, EventArgs e)
        //{
        //    if(openImportFile.ShowDialog() == DialogResult.OK)
        //    {
        //        fileImportTxt.Text = openImportFile.FileName;
        //    }
        //}

        //private void btnFileExport_Click(object sender, EventArgs e)
        //{
        //    if (openExportFile.ShowDialog() == DialogResult.OK)
        //    {
        //        fileExportTxt.Text = openExportFile.FileName;
        //    }
        //}

    }
}
