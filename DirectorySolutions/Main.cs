using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using DirectorySolutions.UserControls;
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
        private int mainFormStartingHeight;

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
            mainFormStartingHeight = Height;
            freshDir.Checked = true;
            SubscribeToModelEvents();
        }

        private void SubscribeToModelEvents()
        {
            m_Model.filePathChanged += M_Model_filePathChanged1;
            m_Model.fileListChanged += M_Model_fileListChanged;
            m_Model.appStateChanged += M_Model_appStateChanged;
            m_Model.activeControlChanged += M_Model_activeControlChanged;
        }


        #region DisplayUpdates

        private void UpdateStatusDisplay()
        {
            countLbl.Text = m_Model.GetFileCount().ToString() + " Files";
            sizeLbl.Text = m_Model.GetSumFileLengths();
            sortedByLbl.Text = m_Model.GetSortedBy(false).GetDescription();
            instructionLbl.Text = presenter.DetermineInstructions();
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
               
                if(!presenter.FindAllFilesInTheDirectory(args.AllPaths, out error, m_Model.GetSortedBy(false)))
                {
                    filePathErrorProv.SetError(filePath, error);
                }
                else
                {
                    filePathErrorProv.Clear();
                }                
            }
        }
      
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
            m_Model.SetActiveFilePath(filePath.Text, saveDir.Checked);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var path = e.Url.ToString().Replace("file:///", "").Replace("file://", "");           
            if(string.Equals(filePath.Text, path))
            {
                m_Model.RaiseFilePathChangedEvent(path, m_Model.GetAllFilePaths());
            }
            else
            {
                filePath.Text = path;
            }
        }

        #endregion

        #region FileSorting

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.SizeAsc)
            {
                presenter.SortMainFileList(DisplaySortOptionEnum.SizeDesc);
            }
            else
            {
                presenter.SortMainFileList(DisplaySortOptionEnum.SizeAsc);
            }

            UpdateStatusDisplay();
        }
        
        private void dateModifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.DateAsc)
            {
                presenter.SortMainFileList(DisplaySortOptionEnum.DateDesc);
            }
            else
            {
                presenter.SortMainFileList(DisplaySortOptionEnum.DateAsc);
            }

            UpdateStatusDisplay();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.NameAsc)
            {
                presenter.SortMainFileList(DisplaySortOptionEnum.NameDesc);
            }
            else
            {
                presenter.SortMainFileList(DisplaySortOptionEnum.NameAsc);
            }

            UpdateStatusDisplay();
        }

        #endregion

        #region FileOperations

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control[] controls = Controls.Find("FindAndReplaceControls", true);
            if (controls.Length < 1)
            {
                FindAndReplaceControls findAndReplaceControls = new FindAndReplaceControls(m_Model, presenter);
                ShiftUserControlDisplay(findAndReplaceControls);
            }            
        }

        private void nameFilesAfterPathToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Control[] controls = Controls.Find("RenameFileForPath", true);
            if (controls.Length < 1)
            {
                RenameFileForPath renameFileForPath = new RenameFileForPath(m_Model, presenter);
                ShiftUserControlDisplay(renameFileForPath);           
            }
        }

        #endregion

        #region UserControl

        private void M_Model_activeControlChanged(object sender, MainModel.ControlEventArgs args)
        {
            instructionLbl.Text = presenter.DetermineInstructions();
        }

        private void RemoveUnactiveUserControl()
        {
            var activeControl = m_Model.GetActiveUserControl();
            if(activeControl != null)
            {
                var controls = Controls.Find(activeControl.Name, true);
                if(controls.Length > 0)
                {
                    Controls.Remove(controls[0]);
                }
            }
        }

        private void ShiftUserControlDisplay(UserControl control)
        {
            RemoveUnactiveUserControl();
            m_Model.SetActiveControl(control);
            Height = mainFormStartingHeight + control.Height + 10;
            Controls.Add(control);
            control.Location =
                new Point(Width / 2 - (control.Width / 2), webBrowser1.Top + webBrowser1.Height + 10);
        }

        #endregion
    }
}
