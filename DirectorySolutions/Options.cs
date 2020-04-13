using System;
using System.IO;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            defaultPathTxt.Text = Properties.Settings.Default["Path"].ToString();
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your directory path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    defaultPathTxt.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Directory.Exists(defaultPathTxt.Text))
            {
                Properties.Settings.Default["Path"] = defaultPathTxt.Text;
                Properties.Settings.Default.Save();
                Close();
            }
            else
            {
                MessageBox.Show("Could not find the directory: " + defaultPathTxt.Text, "Path not found");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
