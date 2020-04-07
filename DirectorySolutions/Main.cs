using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using DirectorySolutions.Views;
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
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter presenter = null;
        private readonly MainModel m_Model;
        
        public string path
        {
            get
            {
                return filePath.Text;
            }
            set
            {
                filePath.Text = value;
            }
        }

        public MainForm(MainModel model)
        {
            m_Model = model;
            InitializeComponent();
            presenter = new MainPresenter(this, m_Model);
            SubscribeToModelEvents();
        }

        private void SubscribeToModelEvents()
        {
            m_Model.filePathChanged += M_Model_filePathChanged1;
            m_Model.fileListChanged += M_Model_fileListChanged;
            m_Model.appStateChanged += M_Model_appStateChanged;
        }

        #region DisplayUpdates

        private void UpdateStatusDisplay()
        {
            countLbl.Text = m_Model.GetFileCount().ToString() + " Files";
            sizeLbl.Text = m_Model.GetSumFileLengths();
            sortedByLbl.Text = m_Model.GetSortedBy(false).GetDescription();
        }

        #endregion

        #region DirectorySelection
        private void M_Model_appStateChanged(object sender, MainModel.StateChangeEventArgs args)
        {
            statusLabel.Text = m_Model.GetApplicationState().GetDescription();
        }

        private void M_Model_fileListChanged(object sender, MainModel.FilesEventArgs args)
        {
            try
            {
                displayGrid.DataSource = null;
                displayGrid.DataSource = m_Model.GetFiles();
                UpdateStatusDisplay();
                filePathErrorProv.Clear();
            }
            catch(Exception e)
            {
                filePathErrorProv.SetError(filePath, e.Message);
            } 
        }

        private void M_Model_filePathChanged1(object sender, MainModel.PathEventArgs args)
        {
            displayGrid.DataSource = null;
            if (Directory.Exists(args.Data))
            {
                string error;
                instructionLbl.Text = presenter.DetermineInstructions();
                if(!presenter.FindAllFilesInTheDirectory(args.Data, out error))
                {
                    filePathErrorProv.SetError(filePath, error);
                }
                else
                {
                    filePathErrorProv.Clear();
                }                
            }
        }

        //private void FindAndReplaceControls_FindReplaceClicked1(object sender, EventArgs e)
        //{
        //    if (findAndReplaceControls.SetAndValidateReplacementTexts())
        //    {
        //        if (FileOperations.FindAndReplace(FileOperations.getFiles(),
        //            findAndReplaceControls.getInText(),
        //            findAndReplaceControls.getOutText()))
        //        {
        //            if (Directory.Exists(path))
        //            {
        //                UpdateDisplay(path);
        //            }
        //        }
        //    }
        //}

        //private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!isExpanded)
        //    {
        //        ExpandOrContractMainForm(800, isExpanded);
        //    }
        //    if(!string.IsNullOrEmpty(path))
        //    {
        //        SetInstructionsForUserControls(findAndReplaceControls);
        //    }
        //    RemoveUnusedUserControls(new List<UserControl>() { directorySelectionControls, findAndReplaceControls });
        //    activeControl = findAndReplaceControls;
        //    findAndReplaceControls.Show();
        //}

        //public void ExpandOrContractMainForm(int height, bool expanded)
        //{
        //    Size = new Size(Size.Width, height);
        //    isExpanded = expanded ? false : true;
        //}

        //private void RemoveUnusedUserControls(List<UserControl> usedControls)
        //{
        //    List<UserControl> allUserControls = new List<UserControl>() { findAndReplaceControls, directorySelectionControls, findExtensionControls };
        //    foreach(var control in allUserControls)
        //    {
        //        if (!usedControls.Contains(control))
        //        {
        //            control.Hide();
        //        }
        //    }
        //}
     
        //private void findAllExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!isExpanded)
        //    {
        //        ExpandOrContractMainForm(800, isExpanded);
        //    }
        //    if (!string.IsNullOrEmpty(path))
        //    {
        //        SetInstructionsForUserControls(findExtensionControls);
        //    }
        //    RemoveUnusedUserControls(new List<UserControl>() { directorySelectionControls, findExtensionControls });
        //    activeControl = findExtensionControls;
        //    findExtensionControls.Show();
        //}
              
        //private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if(sortedByEnum != DisplaySortOptionEnum.SizeAsc)
        //    {
        //        sortedByEnum = DisplaySortOptionEnum.SizeAsc;
        //        files = files.OrderBy(x => x.Length).ToList();
        //        displayGrid.DataSource = null;
        //        displayGrid.DataSource = files;
        //    }
        //    else
        //    {
        //        sortedByEnum = DisplaySortOptionEnum.SizeDesc;
        //        files = files.OrderByDescending(x => x.Length).ToList();
        //        displayGrid.DataSource = null;
        //        displayGrid.DataSource = files;
        //    }
        //}

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your directory path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                }
            }
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

        private void filePath_TextChanged(object sender, EventArgs e)
        {
            m_Model.SetFilePath(filePath.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var path = e.Url.ToString().Replace("file:///", "").Replace("file://", "");
            filePath.Text = path;
        }

        #endregion

        #region FileSorting
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.SizeAsc)
            {
                presenter.SortFileList(DisplaySortOptionEnum.SizeDesc);
            }
            else
            {
                presenter.SortFileList(DisplaySortOptionEnum.SizeAsc);
            }

            UpdateStatusDisplay();
        }

     

        private void dateModifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.DateAsc)
            {
                presenter.SortFileList(DisplaySortOptionEnum.DateDesc);
            }
            else
            {
                presenter.SortFileList(DisplaySortOptionEnum.DateAsc);
            }

            UpdateStatusDisplay();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.NameAsc)
            {
                presenter.SortFileList(DisplaySortOptionEnum.NameDesc);
            }
            else
            {
                presenter.SortFileList(DisplaySortOptionEnum.NameAsc);
            }

            UpdateStatusDisplay();
        }

        #endregion
    }
}
