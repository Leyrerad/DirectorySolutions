using DirectorySolutions.Models;
using DirectorySolutions.Views;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace DirectorySolutions.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView m_View;
        private IMainModel m_Model;
        private static Logger logger = LogManager.GetCurrentClassLogger();
      

        public MainPresenter(IMainView view, IMainModel model)
        {
            this.m_View = view;
            this.m_Model = model;
        }
        
        #region FileOperations

        public bool FindAllFilesInTheDirectory(List<string> sDir, out string error, DisplaySortOptionEnum sortedBy = DisplaySortOptionEnum.None, bool raiseEvent = true)
        {
            try
            {
                m_Model.SetApplicationState(ApplicationStateEnum.LoadingFiles);
                List<FileInfo> allFiles = new List<FileInfo>();

                foreach (var dir in sDir)
                {
                    var allFileNames = allFiles.Select(x => x.FullName).ToList();
                    var files = FileOperations.PopulateFileInformation(dir, out error);
                    var doubles = files.Where(x => allFileNames.Contains(x.FullName)).ToList();
                    files = files.Except(doubles).ToList();
                    allFiles.AddRange(files);
                }

                error = "";
                if (allFiles != null)
                {
                    if (sortedBy != DisplaySortOptionEnum.None)
                    {
                        allFiles = SortFileList(allFiles, sortedBy);   
                    }

                    m_Model.SetSortedByEnum(sortedBy, false);
                    m_Model.SetFileList(allFiles, raiseEvent);
                }
                else
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    return false;
                }

                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                return true;
            }
            catch(Exception e)
            {
                logger.Fatal(e);
                error = e.Message;
                return false;
            }          
        }

        public void SortMainDisplay(DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None, bool raiseEvent = true)
        {
            var displayOption = m_Model.GetGridViewOption();
            m_Model.SetApplicationState(ApplicationStateEnum.SortingFiles);
            var files = m_Model.GetFiles();
            var movies = m_Model.GetMovieList();
            if (m_Model.GetSortedBy(false) != sortBy)
            {
                switch (sortBy)
                {
                    case (DisplaySortOptionEnum.DateAsc):
                        files = files.OrderBy(x => x.LastWriteTime).ToList();
                        movies = movies == null ? null : movies.OrderBy(x => Convert.ToInt32(x.Year)).ToList();
                        break;
                    case (DisplaySortOptionEnum.DateDesc):
                        files = files.OrderByDescending(x => x.LastWriteTime).ToList();
                        movies = movies == null ? null : movies.OrderByDescending(x => Convert.ToInt32(x.Year)).ToList();
                        break;
                    case (DisplaySortOptionEnum.SizeAsc):
                        files = files.OrderBy(x => x.Length).ToList();
                        movies = movies == null ? null : movies.OrderBy(x => x.FileSize).ToList();
                        break;
                    case (DisplaySortOptionEnum.SizeDesc):
                        files = files.OrderByDescending(x => x.Length).ToList();
                        movies = movies == null ? null : movies.OrderByDescending(x => x.FileSize).ToList();
                        break;
                    case (DisplaySortOptionEnum.NameAsc):
                        files = files.OrderBy(x => x.Name).ToList();
                        movies = movies == null ? null : movies.OrderBy(x => x.Title).ToList();
                        break;
                    case (DisplaySortOptionEnum.NameDesc):
                        files = files.OrderByDescending(x => x.Name).ToList();
                        movies = movies == null ? null : movies.OrderByDescending(x => x.Title).ToList();
                        break;
                    default:
                        break;
                }
            }
            m_Model.SetSortedByEnum(sortBy, false);
            if (displayOption == GridViewOptionEnum.Files)
            {
                m_Model.SetFileList(files, raiseEvent);
            }
            else if (displayOption == GridViewOptionEnum.Movies)
            {
                m_Model.SetMovieList(movies, raiseEvent);
            }
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
        }

        public List<FileInfo> SortFileList(List<FileInfo> files, DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.SortingFiles);
            files = FileOperations.SortFileList(files, sortBy);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return files;
        }
        
        public bool RenameFilesByDirectory(int numberOfDirs, NameByPathSeperatorEnum seperator, DisplaySortOptionEnum sortBy, out string error, out string displayFileName,
            bool incrementNames = false, bool spaceBuffer = false, bool forDisplay = false)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            if (!FileOperations.RenameFilesByDirectory(m_Model.GetFiles(), numberOfDirs, m_Model.GetFileNameByPathSeperatorTuple(seperator), 
                sortBy, out error, out displayFileName, incrementNames, spaceBuffer, forDisplay))
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.RaiseFilePathChangedEvent(m_Model.GetAllFilePaths());
            return true;          
        }

        public bool FindAndReplace(string inText, string outText, out string error, int targetOptionIndex)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            List<string> newSearchDirectories;
            switch (targetOptionIndex)
            {
                case 0:
                    if (!FileOperations.FindAndReplaceOnFiles(m_Model.GetFiles(), inText, outText, out error))
                    {
                        m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                        logger.Debug(error);
                        return false;
                    }
                    break;
                case 1:
                    if (!FileOperations.FindAndReplaceOnParentDirectories(m_Model.GetFiles(), inText, outText, out error))
                    {
                        m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                        logger.Debug(error);
                        return false;
                    }
                    break;
                case 2:                   
                    if (!FileOperations.FindAndReplaceOnFullPath(m_Model.GetFiles(), inText, outText, out error, out newSearchDirectories))
                    {
                        m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                        logger.Debug(error);
                        return false;
                    }
                    if(newSearchDirectories != null && newSearchDirectories.Count > 0)
                    {
                        m_Model.ReplaceFilePaths(newSearchDirectories, false);
                    }
                    break;
                default:
                    if (!FileOperations.FindAndReplaceOnFiles(m_Model.GetFiles(), inText, outText, out error))
                    {
                        m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                        logger.Debug(error);
                        return false;
                    }
                    break;
            }
            m_Model.RaiseFilePathChangedEvent(m_Model.GetAllFilePaths());
            return true;           
        }

        public bool PreAndAppend(string prepend, string append, out string error)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            if (!FileOperations.PreAndAppendFileNames(m_Model.GetFiles(), prepend, append, out error))
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.RaiseFilePathChangedEvent(m_Model.GetAllFilePaths());
            return true;
        }

        public bool SaveToExcel(DataGridView displayGrid, out string error)
        {
            error = "";
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Files in Path(s)";
                for (int i = 1; i < displayGrid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = displayGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < displayGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < displayGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = displayGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worksheet.Columns.AutoFit();
                return true;
            }
            catch(Exception e)
            {
                error = e.Message;
                return false;
            }           
        }

        public bool MoveFiles(out string error, string sDir)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            if (!FileOperations.MoveFiles(m_Model.GetFiles(), sDir, out error))
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.RaiseFilePathChangedEvent(m_Model.GetAllFilePaths());
            return true;
        }

        public bool FilterFileListBySearchOptions(FileSearch fileSearchOptions, out string error, bool raiseEvent = true)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var fileList = FileOperations.FilterFileListBySearchOptions(m_Model.GetFiles(), fileSearchOptions, out error);
            if (fileList == null)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.SetFileList(fileList, raiseEvent);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        public bool AddFilesFromFileList(ListBox.ObjectCollection files, out string error, bool freshDir, bool raiseEvent = true)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var fileList = FileOperations.AddFilesFromFileList(files, out error);
            if (fileList == null)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            if (freshDir)
            {
                m_Model.SetFileList(fileList, raiseEvent);
            }
            else
            {
                fileList.AddRange(m_Model.GetFiles());
                if(m_Model.GetSortedBy(false) != DisplaySortOptionEnum.None)
                {
                    fileList = SortFileList(fileList, m_Model.GetSortedBy(false));                      
                }
                m_Model.SetFileList(fileList, raiseEvent);
            }
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        public bool GetFileNamesAsList(out string error, out string files)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            if (!FileOperations.GetFileNamesAsList(m_Model.GetFiles(), out error, out files))
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }           
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        public bool OpenFilesFromList(List<FileInfo> files, out string error, bool replaceList = true)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            error = null;
            try
            {
                if (replaceList)
                {
                    m_Model.SetFileList(files, true);
                }                

                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                return true;
            }
            catch (Exception e)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                error = e.Message;
                logger.Fatal(e);
                return false;
            }
          
        }

        public bool EditFileName(string oldName, string newName, string directoryName, out string error)
        {

            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            error = null;
            try
            {
                if(!string.Equals(Path.GetExtension(newName), Path.GetExtension(oldName)))
                {
                    error = "The extension for the new file name does not match the old file name.";
                    return false;
                }

                File.Move(Path.Combine(directoryName, oldName), Path.Combine(directoryName, newName));

                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                return true;
            }
            catch (Exception e)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                error = e.Message;
                logger.Fatal(e);
                return false;
            }
        }


        #endregion

        #region DisplayMethods

        public void ClearAllTextFields(ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
            }
        }

        public bool RefreshModelLists(out string error)
        {     
            var displayOption = m_Model.GetGridViewOption();
            switch (displayOption)
            {
                case GridViewOptionEnum.Files:
                    if (!FindAllFilesInTheDirectory(m_Model.GetAllFilePaths(), out error, m_Model.GetSortedBy(false)))
                    {
                        return false;
                    }
                    break;
                case GridViewOptionEnum.Movies:
                    if (!FindAllFilesInTheDirectory(m_Model.GetAllFilePaths(), out error, DisplaySortOptionEnum.None))
                    {
                        return false;
                    }
                    if (!ParseMovieInfoFilesInPath(out error, m_Model.GetSortedBy(false)))
                    {
                        return false;
                    }
                    break;
                default:
                    if (!FindAllFilesInTheDirectory(m_Model.GetAllFilePaths(), out error, m_Model.GetSortedBy(false)))
                    {
                        return false;
                    }
                    break;
            }
            
            return true;
        }

        public bool PopulateFastPathContextMenu(ContextMenuStrip fastPathMenuStrip, out string error, ref List<string> fastPaths)
        {
            error = "";            
            try
            {
                fastPathMenuStrip.Items.Clear();
                if (fastPaths != null && fastPaths.Count > 0)
                {
                    ToolStripMenuItem[] items = new ToolStripMenuItem[fastPaths.Count];
                    for (int i = 0; i < items.Length; i++)
                    {
                        var item = new ToolStripMenuItem();
                        item.Name = fastPaths[i];
                        item.Text = fastPaths[i];
                        item.Click += new EventHandler(MenuItemClickHandler);

                        fastPathMenuStrip.Items.Add(item);
                    }
                }
                else
                {
                    fastPaths = new List<string>();
                }

                return true;
            }
            catch(Exception e)
            {
                error = e.Message;
                return false;
            }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    var buttonsToKeys = m_Model.GetButtonToTextKeyPair();
                    Control control = owner.SourceControl;
                    if (buttonsToKeys.ContainsKey(control.Name))
                    {
                        var textBoxName = buttonsToKeys[control.Name];
                        var controls = control.Parent.Controls.Find(textBoxName, true);
                        if(controls.Length > 0)
                        {
                            controls[0].Text = menuItem.Name;
                        }
                    }
                    
                }
            }
        }

        #endregion

        #region Movie File Ops

        public async Task<bool> GenerateInformationFilesForMovies()
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var filesCreated = await ApiManager.CreateMovieInfoFiles(m_Model.GetFiles());
            m_Model.RaiseFilePathChangedEvent(m_Model.GetAllFilePaths());
            return filesCreated ? true : false;
        }

        public bool ParseMovieInfoFilesInPath(out string error, DisplaySortOptionEnum sortedBy, bool raiseEvent = true)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var movieList = ApiManager.ParseMovieInfoFiles(m_Model.GetFiles(), out error);
            if (movieList == null)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }

            if(sortedBy != DisplaySortOptionEnum.None)
            {
                movieList = ApiManager.SortMovieList(movieList, sortedBy);
            }

            m_Model.SetMovieList(movieList, raiseEvent);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        public bool FilterMovieListBySearchOptions(MovieSearch movieSearchOptions, out string error, bool raiseEvent = true)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var movieList = ApiManager.FilterMovieListBySearchOptions(m_Model.GetMovieList(), movieSearchOptions, out error);
            if (movieList == null)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.SetMovieList(movieList, raiseEvent);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        #endregion
    }

    
}
