using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class FileDetails : Form
    {
        private FileInfo file;
        private MainModel mainModel;
        private MainPresenter presenter;

        public FileDetails(FileInfo file, MainModel mainModel, MainPresenter presenter)
        {
            InitializeComponent();
            this.file = file;
            this.mainModel = mainModel;
            this.presenter = presenter;
            PopulateFields();
        }

        private void PopulateFields()
        {
            fileNameTxt.Text = file.Name;
            fullNameTxt.Text = file.FullName;
            sizeTxt.Text = mainModel.SizeSuffix(file.Length);
            lastWriteTxt.Text = file.LastWriteTime.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + file.FullName + "\"";
            fileopener.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error;
            if(!presenter.EditFileName(file.Name, fileNameTxt.Text, file.DirectoryName, out error))
            {
                MessageBox.Show(error, "Error");
            }
            else
            {
                file = new FileInfo(Path.Combine(file.DirectoryName, fileNameTxt.Text));
                PopulateFields();
            }
        }
    }
}
