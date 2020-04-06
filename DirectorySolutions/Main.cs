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
        private UserControl activeControl;
        private List<FileInfo> files;
        private DisplaySortOptionEnum sortedByEnum;

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
                if (!isExpanded && activeControl == null)
                {
                    SetInstructionsForUserControls(directorySelectionControls);
                }
                else
                {
                    SetInstructionsForUserControls(activeControl);
                }
               
                UpdateDisplay(path);
            }
        }

        private void FindAndReplaceControls_FindReplaceClicked1(object sender, EventArgs e)
        {
            if (findAndReplaceControls.SetAndValidateReplacementTexts())
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

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                ExpandOrContractMainForm(800, isExpanded);
            }
            if(!string.IsNullOrEmpty(path))
            {
                SetInstructionsForUserControls(findAndReplaceControls);
            }
            RemoveUnusedUserControls(new List<UserControl>() { directorySelectionControls, findAndReplaceControls });
            activeControl = findAndReplaceControls;
            findAndReplaceControls.Show();
        }

        public void ExpandOrContractMainForm(int height, bool expanded)
        {
            Size = new Size(Size.Width, height);
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
            if (!Directory.GetDirectories(path).Any())
            {
                await Task.Run(() => { FileOperations.DirSearch(path); });
            }
            else
            {
                await Task.Run(() => { FileOperations.DirSearchRecursive(path); }); ;
            }
            files = FileOperations.getFiles();
            displayGrid.DataSource = null;
            displayGrid.DataSource = files;
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
                ExpandOrContractMainForm(800, isExpanded);
            }
            if (!string.IsNullOrEmpty(path))
            {
                SetInstructionsForUserControls(findExtensionControls);
            }
            RemoveUnusedUserControls(new List<UserControl>() { directorySelectionControls, findExtensionControls });
            activeControl = findExtensionControls;
            findExtensionControls.Show();
        }

        private void SetInstructionsForUserControls(UserControl control)
        {
            switch (control.Name)
            {
                case "findAndReplaceControls":
                    instructionLbl.Font = new Font(instructionLbl.Font.FontFamily, 8);
                    instructionLbl.Text = "Please enter the text you would like to replace for all file names in the directory.";
                    break;
                case "findExtensionControls":
                    instructionLbl.Font = new Font(instructionLbl.Font.FontFamily, 8);
                    instructionLbl.Text = "Please enter the extension you would like to find for all files in this directory.";
                    break;
                case "directorySelectionControls":
                    instructionLbl.Font = new Font(instructionLbl.Font.FontFamily, 10);
                    instructionLbl.Text = "Please select a directory to get started.";
                    break;
                default:
                    instructionLbl.Font = new Font(instructionLbl.Font.FontFamily, 10);
                    instructionLbl.Text = "Please select an operation to execute on this directory.";
                    break;
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sortedByEnum != DisplaySortOptionEnum.SizeAsc)
            {
                sortedByEnum = DisplaySortOptionEnum.SizeAsc;
                files = files.OrderBy(x => x.Length).ToList();
                displayGrid.DataSource = null;
                displayGrid.DataSource = files;
            }
            else
            {
                sortedByEnum = DisplaySortOptionEnum.SizeDesc;
                files = files.OrderByDescending(x => x.Length).ToList();
                displayGrid.DataSource = null;
                displayGrid.DataSource = files;
            }
        }

        public string GetPathFromMainForm()
        {
            return path;
        }
    }
}
