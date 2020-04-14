﻿using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using DirectorySolutions.UserControls;
using DirectorySolutions.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter presenter = null;
        private readonly MainModel m_Model;
        private int mainFormStartingHeight;
        private Color buttonColor;

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
            freshListRad.Checked = true;
            displayGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubscribeToModelEvents();
            CreateDragAndDropEvents();
            SetToolTips();            
            LoadDefaults();
            buttonColor = btnFilterFiles.BackColor;
            displayGrid.CellDoubleClick += DisplayGrid_CellDoubleClick;
        }

        private void DisplayGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string error;
            var frm = new FileDetails(m_Model.GetFiles().ElementAt(e.RowIndex), m_Model, presenter);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { 
                this.Show(); 
                presenter.RefreshModelLists(out error); 
            };
            frm.Show();
            this.Hide();

        }

        private void SubscribeToModelEvents()
        {
            m_Model.filePathChanged += M_Model_filePathChanged1;
            m_Model.fileListChanged += M_Model_fileListChanged;
            m_Model.appStateChanged += M_Model_appStateChanged;
            m_Model.movieListChanged += M_Model_movieListChanged;
            m_Model.gridViewOptionChanged += M_Model_gridViewOptionChanged;
            m_Model.activeControlChanged += M_Model_activeControlChanged;
        }

      

        #region Display

        private void LoadDefaults()
        {
            try
            {
                path = Properties.Settings.Default["Path"].ToString();
                webBrowser1.Url = new Uri(path);
                filePath.Text = path;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void SetToolTips()
        {
            tooltipFreshDir.SetToolTip(picInfoFreshDir, "By clicking 'Save Directory' the previously compiled file list " +
                "will be appended to that of the next path that is opened. Click this icon to view all saved file paths.");
        }

        private void UpdateStatusDisplay(GridViewOptionEnum displayOption)
        {
            countLbl.Text = m_Model.GetFileCount(displayOption).ToString() + " Files";
            sizeLbl.Text = m_Model.GetSumFileLengths(displayOption);
            sortedByLbl.Text = m_Model.GetSortedBy(false).GetDescription();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_Model.RaiseFilePathChangedEvent(m_Model.GetActiveFilePath(), m_Model.GetAllFilePaths());
        }

        private void M_Model_appStateChanged(object sender, MainModel.StateChangeEventArgs args)
        {
            statusLabel.Text = m_Model.GetApplicationState().GetDescription();
        }

        private void M_Model_gridViewOptionChanged(object sender, MainModel.GridViewEventArgs args)
        {
            string error;
            switch (args.Option)
            {
                case GridViewOptionEnum.Files:
                    m_Model.RaiseFilePathChangedEvent(m_Model.GetActiveFilePath(), m_Model.GetAllFilePaths());
                    break;
                case GridViewOptionEnum.Movies:                    
                    if (!presenter.ParseMovieInfoFilesInPath(out error, m_Model.GetSortedBy(false)))
                    {
                        MessageBox.Show(error);
                    }
                    break;
                default:
                    break;
            }
        }

        private void picInfoFreshDir_Click(object sender, EventArgs e)
        {
            var dirs = m_Model.GetAllFilePaths();
            MessageBox.Show(string.Join("\n", dirs), "All File Paths for the File List");
        }

        private void M_Model_activeControlChanged(object sender, MainModel.ControlEventArgs args)
        {
            UpdateFileToolSetButtonDisplay();
        }

        private void UpdateFileToolSetButtonDisplay()
        {
            
            List <Control> controls = new List<Control>() { btnFilterFiles, btnFindandReplace, btnFindDuplicates, btnMovieManagement, btnNameFilesForPath };
            foreach(var cntrl in controls)
            {
                if (cntrl.Focused)
                {
                    cntrl.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                }
                else
                {
                    cntrl.BackColor = buttonColor;
                }
            }
            
        }

        #endregion

        #region DirectorySelection

        private void CreateDragAndDropEvents()
        {
            fileOpenList.DragEnter += FileOpenList_DragEnter;
            fileOpenList.DragDrop += FileOpenList_DragDrop;
        }

        private void FileOpenList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
            {
                foreach(var file in files)
                {
                    fileOpenList.Items.Add(file);
                }
            }               
        }

        private void FileOpenList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void M_Model_fileListChanged(object sender, MainModel.FilesEventArgs args)
        {
            try
            {
                displayGrid.DataSource = null;
                var option = m_Model.GetGridViewOption();
                switch (option)
                {
                    case GridViewOptionEnum.Files:
                        displayGrid.DataSource = m_Model.GetFiles();
                        break;
                    case GridViewOptionEnum.Movies:
                        displayGrid.DataSource = m_Model.GetMovieList();
                        break;
                    default:
                        displayGrid.DataSource = m_Model.GetFiles();
                        break;
                }
                
                UpdateStatusDisplay(m_Model.GetGridViewOption());
                filePathErrorProv.Clear();
            }
            catch(Exception e)
            {
                filePathErrorProv.SetError(filePath, e.Message);
            } 
        }

        private void M_Model_filePathChanged1(object sender, MainModel.PathEventArgs args)
        {
            string error;               
            if(!presenter.RefreshModelLists(out error))
            {
                filePathErrorProv.SetError(filePath, error);
            }
            else
            {
                filePathErrorProv.Clear();
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
                presenter.SortMainDisplay(DisplaySortOptionEnum.SizeDesc);
            }
            else
            {
                presenter.SortMainDisplay(DisplaySortOptionEnum.SizeAsc);
            }

            UpdateStatusDisplay(m_Model.GetGridViewOption());
        }
        
        private void dateModifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.DateAsc)
            {
                presenter.SortMainDisplay(DisplaySortOptionEnum.DateDesc);
            }
            else
            {
                presenter.SortMainDisplay(DisplaySortOptionEnum.DateAsc);
            }

            UpdateStatusDisplay(m_Model.GetGridViewOption());
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(m_Model.GetSortedBy(false) == DisplaySortOptionEnum.NameAsc)
            {
                presenter.SortMainDisplay(DisplaySortOptionEnum.NameDesc);
            }
            else
            {
                presenter.SortMainDisplay(DisplaySortOptionEnum.NameAsc);
            }

            UpdateStatusDisplay(m_Model.GetGridViewOption());
        }

        #endregion

        #region FileOperations
             
        private void btnMovieManagement_Click(object sender, EventArgs e)
        {
            Control[] controls = Controls.Find("MovieManagement", true);
            if (controls.Length < 1)
            {
                MovieManagement movieManagement = new MovieManagement(m_Model, presenter);
                ShiftUserControlDisplay(movieManagement);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(var file in dialog.FileNames)
                    {
                        fileOpenList.Items.Add(file);
                    }                    
                }
            }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            string error;
            if(!presenter.AddFilesFromFileList(fileOpenList.Items, out error, freshListRad.Checked))
            {
                MessageBox.Show(error, "Error");
            }           
        }

        private void saveFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string files;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Can use dialog.FileName
                    using (Stream stream = dialog.OpenFile())
                    {
                        string error;
                        if (!presenter.GetFileNamesAsList(out error, out files))
                        {
                            MessageBox.Show(error, "Error");
                        }

                        using (var sw = new StreamWriter(stream))
                        {
                            sw.WriteLine(files);
                        }
                    }
                }
            }

        }

        private void openFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var files = new List<FileInfo>();
            string error;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (File.Exists(line))
                            {
                                files.Add(new FileInfo(line));
                            }
                        }
                    }

                    if (!presenter.OpenFilesFromList(files, out error))
                    {
                        MessageBox.Show(error, "Error");
                    }
                }
            }
        }

        private void btnFilterFiles_Click(object sender, EventArgs e)
        {
            Control[] controls = Controls.Find("FilterFiles", true);
            if (controls.Length < 1)
            {
                FilterFiles filterFiles = new FilterFiles(m_Model, presenter);
                ShiftUserControlDisplay(filterFiles);
            }
        }

        private void btnNameFilesForPath_Click(object sender, EventArgs e)
        {
            Control[] controls = Controls.Find("RenameFileForPath", true);
            if (controls.Length < 1)
            {
                RenameFileForPath renameFileForPath = new RenameFileForPath(m_Model, presenter);
                ShiftUserControlDisplay(renameFileForPath);
            }
        }

        private void btnFindandReplace_Click(object sender, EventArgs e)
        {
            Control[] controls = Controls.Find("FindAndReplaceControls", true);
            if (controls.Length < 1)
            {
                FindAndReplaceControls findAndReplaceControls = new FindAndReplaceControls(m_Model, presenter);
                ShiftUserControlDisplay(findAndReplaceControls);
            }
        }

        #endregion

        #region MovieOperations

        private void M_Model_movieListChanged(object sender, MainModel.MoviesEventArgs args)
        {
            try
            {
                displayGrid.DataSource = null;
                displayGrid.DataSource = m_Model.GetMovieList();
                UpdateStatusDisplay(m_Model.GetGridViewOption());
                filePathErrorProv.Clear();
            }
            catch (Exception e)
            {
                filePathErrorProv.SetError(filePath, e.Message);
            }
        }

        #endregion

        #region UserControl

        private void RemoveUnactiveUserControl()
        {
            var activeControl = m_Model.GetActiveUserControl();
            if (activeControl != null)
            {
                var controls = fileToolsPanel.Controls.Find(activeControl.Name, true);
                if (controls.Length > 0)
                {
                    fileToolsPanel.Controls.Remove(controls[0]);
                }
            }
        }

        private void ShiftUserControlDisplay(UserControl control)
        {
            RemoveUnactiveUserControl();
            m_Model.SetActiveControl(control);
            m_Model.SetGridViewOption(m_Model.DetermineGridViewOption(control));
            fileToolsPanel.Controls.Add(control);
            control.Location =
                new Point(3,5);
        }

        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string error;
            if(!presenter.SaveToExcel(displayGrid, out error))
            {
                filePathErrorProv.SetError(filePath, error);
            }
            else
            {
                filePathErrorProv.Clear();
            }           
        }

        private void btnClearFileList_Click(object sender, EventArgs e)
        {
            fileOpenList.Items.Clear();
        }

        #region General ops

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Options();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void btnFindDuplicates_Click(object sender, EventArgs e)
        {

        }

      
    }
}
