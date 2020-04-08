using DirectorySolutions.Models;
using DirectorySolutions.Views;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void SortMainFileList(DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.SortingFiles);
            var files = m_Model.GetFiles();
            if (m_Model.GetSortedBy(false) != sortBy)
            {
                switch (sortBy)
                {
                    case (DisplaySortOptionEnum.DateAsc):
                        files = files.OrderBy(x => x.LastWriteTime).ToList();
                        m_Model.SetSortedByEnum(DisplaySortOptionEnum.DateAsc, false);
                        break;
                    case (DisplaySortOptionEnum.DateDesc):
                        files = files.OrderByDescending(x => x.LastWriteTime).ToList();
                        m_Model.SetSortedByEnum(DisplaySortOptionEnum.DateDesc, false);
                        break;
                    case (DisplaySortOptionEnum.SizeAsc):
                        files = files.OrderBy(x => x.Length).ToList();
                        m_Model.SetSortedByEnum(DisplaySortOptionEnum.SizeAsc, false);
                        break;
                    case (DisplaySortOptionEnum.SizeDesc):
                        files = files.OrderByDescending(x => x.Length).ToList();
                        m_Model.SetSortedByEnum(DisplaySortOptionEnum.SizeDesc, false);
                        break;
                    case (DisplaySortOptionEnum.NameAsc):
                        files = files.OrderBy(x => x.Name).ToList();
                        m_Model.SetSortedByEnum(DisplaySortOptionEnum.NameAsc, false);
                        break;
                    case (DisplaySortOptionEnum.NameDesc):
                        files = files.OrderByDescending(x => x.Name).ToList();
                        m_Model.SetSortedByEnum(DisplaySortOptionEnum.NameDesc, false);
                        break;
                    default:
                        break;
                }
            }
            m_Model.SetFileList(files);
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
        }

        public List<FileInfo> SortFileList(List<FileInfo> files, DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None)
        {
            m_Model.SetApplicationState(ApplicationStateEnum.SortingFiles);
           
            switch (sortBy)
            {
                case (DisplaySortOptionEnum.DateAsc):
                    files = files.OrderBy(x => x.LastWriteTime).ToList();
                    m_Model.SetSortedByEnum(DisplaySortOptionEnum.DateAsc, false);
                    break;
                case (DisplaySortOptionEnum.DateDesc):
                    files = files.OrderByDescending(x => x.LastWriteTime).ToList();
                    m_Model.SetSortedByEnum(DisplaySortOptionEnum.DateDesc, false);
                    break;
                case (DisplaySortOptionEnum.SizeAsc):
                    files = files.OrderBy(x => x.Length).ToList();
                    m_Model.SetSortedByEnum(DisplaySortOptionEnum.SizeAsc, false);
                    break;
                case (DisplaySortOptionEnum.SizeDesc):
                    files = files.OrderByDescending(x => x.Length).ToList();
                    m_Model.SetSortedByEnum(DisplaySortOptionEnum.SizeDesc, false);
                    break;
                case (DisplaySortOptionEnum.NameAsc):
                    files = files.OrderBy(x => x.Name).ToList();
                    m_Model.SetSortedByEnum(DisplaySortOptionEnum.NameAsc, false);
                    break;
                case (DisplaySortOptionEnum.NameDesc):
                    files = files.OrderByDescending(x => x.Name).ToList();
                    m_Model.SetSortedByEnum(DisplaySortOptionEnum.NameDesc, false);
                    break;
                default:
                    break;
            }        
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);
            return files;
        }
        
        public bool RenameFilesByDirectory(int numberOfDirs, NameByPathSeperatorEnum seperator, DisplaySortOptionEnum sortBy, out string error,
            bool incrementNames = false, int containsIncrements = 0, bool spaceBuffer = false)
        {
            try
            {
                m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
                if (!FileOperations.RenameFilesByDirectory(m_Model.GetFiles(), numberOfDirs, m_Model.GetFileNameByPathSeperatorTuple(seperator), 
                    sortBy, out error, incrementNames, containsIncrements, spaceBuffer))
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    logger.Debug(error);
                    return false;
                }
                if (!FindAllFilesInTheDirectory(m_Model.GetAllFilePaths(), out error, m_Model.GetSortedBy(false)))
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    logger.Debug(error);
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Fatal(e);
                error = e.Message;
                return false;
            }
        }

        public bool FindAndReplace(string inText, string outText, out string error)
        {
            try
            {
                m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
                if (!FileOperations.FindAndReplace(m_Model.GetFiles(), inText, outText, out error))
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    logger.Debug(error);
                    return false;
                }
                if (!FindAllFilesInTheDirectory(m_Model.GetAllFilePaths(), out error, m_Model.GetSortedBy(false)))
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    logger.Debug(error);
                    return false;
                }

                return true;
            }
            catch(Exception e)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Fatal(e);
                error = e.Message;
                return false;
            }
        }

        public bool PreAndAppend(string prepend, string append, out string error)
        {
            try
            {
                m_Model.SetApplicationState(ApplicationStateEnum.FileOperation);
                if (!FileOperations.PreAndAppendFileNames(m_Model.GetFiles(), prepend, append, out error))
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    logger.Debug(error);
                    return false;
                }
                if (!FindAllFilesInTheDirectory(m_Model.GetAllFilePaths(), out error, m_Model.GetSortedBy(false)))
                {
                    m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                    logger.Debug(error);
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                m_Model.SetApplicationState(ApplicationStateEnum.Ready);
                logger.Fatal(e);
                error = e.Message;
                return false;
            }
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
                var controlName = control.Name;
                switch (controlName)
                {
                    case "FindAndReplaceControls":
                        return "Please enter the text you would like to replace for all file names in the directory.";
                    case "findExtensionControls":
                        return "Please enter the extension you would like to find for all files in this directory.";
                    default:
                        return "Please select a directory to get started.";
                }
            }
            else
            {
              
               return "Please select an operation to get started.";
                
            }
        }

        #endregion
    }
}
