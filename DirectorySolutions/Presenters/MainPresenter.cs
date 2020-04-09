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

        public bool FindAllFilesInTheDirectory(List<string> sDir, out string error, DisplaySortOptionEnum sortedBy = DisplaySortOptionEnum.None)
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
                if (allFiles != null && allFiles.Count() > 0)
                {
                    if (sortedBy != DisplaySortOptionEnum.None)
                    {
                        allFiles = SortFileList(allFiles, sortedBy);   
                    }

                    m_Model.SetSortedByEnum(sortedBy, false);
                    m_Model.SetFileList(allFiles);
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

        public void SortMainDisplay(DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None)
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
                        movies = movies.OrderBy(x => Convert.ToInt32(x.Year)).ToList();
                        break;
                    case (DisplaySortOptionEnum.DateDesc):
                        files = files.OrderByDescending(x => x.LastWriteTime).ToList();
                        movies = movies.OrderByDescending(x => Convert.ToInt32(x.Year)).ToList();
                        break;
                    case (DisplaySortOptionEnum.SizeAsc):
                        files = files.OrderBy(x => x.Length).ToList();
                        movies = movies.OrderBy(x => x.FileSize).ToList();
                        break;
                    case (DisplaySortOptionEnum.SizeDesc):
                        files = files.OrderByDescending(x => x.Length).ToList();
                        movies = movies.OrderByDescending(x => x.FileSize).ToList();
                        break;
                    case (DisplaySortOptionEnum.NameAsc):
                        files = files.OrderBy(x => x.Name).ToList();
                        movies = movies.OrderBy(x => x.Title).ToList();
                        break;
                    case (DisplaySortOptionEnum.NameDesc):
                        files = files.OrderByDescending(x => x.Name).ToList();
                        movies = movies.OrderByDescending(x => x.Title).ToList();
                        break;
                    default:
                        break;
                }
            }
            m_Model.SetSortedByEnum(sortBy, false);
            if (displayOption == GridViewOptionEnum.Files)
            {
                m_Model.SetFileList(files);
            }
            else if (displayOption == GridViewOptionEnum.Movies)
            {
                m_Model.SetMovieList(movies);
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
        
        public bool RenameFilesByDirectory(int numberOfDirs, NameByPathSeperatorEnum seperator, DisplaySortOptionEnum sortBy, out string error,
            bool incrementNames = false, int containsIncrements = 0, bool spaceBuffer = false)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            if (!FileOperations.RenameFilesByDirectory(m_Model.GetFiles(), numberOfDirs, m_Model.GetFileNameByPathSeperatorTuple(seperator), 
                sortBy, out error, incrementNames, containsIncrements, spaceBuffer))
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.RaiseFilePathChangedEvent(m_Model.GetActiveFilePath(), m_Model.GetAllFilePaths());
            return true;
          
        }

        public bool FindAndReplace(string inText, string outText, out string error)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            if (!FileOperations.FindAndReplace(m_Model.GetFiles(), inText, outText, out error))
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.RaiseFilePathChangedEvent(m_Model.GetActiveFilePath(), m_Model.GetAllFilePaths());
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
            m_Model.RaiseFilePathChangedEvent(m_Model.GetActiveFilePath(), m_Model.GetAllFilePaths());
            return true;
        }
      
        #endregion

        #region DisplayMethods

        public string DetermineInstructions()
        {
            if (string.IsNullOrEmpty(m_Model.GetActiveFilePath()))
            {
                return "Please select a directory to get started.";
            }

            var control = m_Model.GetActiveUserControl();       
            if(control != null)
            {
                return "Please follow the instructions on the inner controls to proceed.";
            }
            else
            {
               return "Please select an operation to get started.";                
            }
        }

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
                    if (!ParseMovieInfoFilesInPath(out error))
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

        public bool RefreshGridViewDisplay()
        {
            var displayOption = m_Model.GetGridViewOption();
            switch (displayOption)
            {
                case GridViewOptionEnum.Files:
                
                    break;
                case GridViewOptionEnum.Movies:
                   
                    break;
                default:
                   
                    break;
            }

            return true;
        }

        #endregion

        #region Movie File Ops

        public async Task<bool> GenerateInformationFilesForMovies()
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var filesCreated = await ApiManager.CreateMovieInfoFiles(m_Model.GetFiles());
            m_Model.RaiseFilePathChangedEvent(m_Model.GetActiveFilePath(), m_Model.GetAllFilePaths());
            return filesCreated ? true : false;
        }

        public bool ParseMovieInfoFilesInPath(out string error)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var movieList = ApiManager.ParseMovieInfoFiles(m_Model.GetFiles(), out error);
            if (movieList == null)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.SetMovieList(movieList);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        public bool FilterMovieListBySearchOptions(MovieSearch movieSearchOptions, out string error)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
            var movieList = ApiManager.FilterMovieListBySearchOptions(m_Model.GetMovieList(), movieSearchOptions, out error);
            if (movieList == null)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Debug(error);
                return false;
            }
            m_Model.SetMovieList(movieList);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return true;
        }

        #endregion
    }
}
