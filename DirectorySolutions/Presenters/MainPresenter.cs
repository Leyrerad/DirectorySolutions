using DirectorySolutions.Models;
using DirectorySolutions.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySolutions.Presenters
{
    class MainPresenter
    {
        private readonly IMainView m_View;
        private IMainModel m_Model;

        public MainPresenter(IMainView view, IMainModel model)
        {
            this.m_View = view;
            this.m_Model = model;
        }

        #region FileOperations

        public bool FindAllFilesInTheDirectory(string sDir, out string error)
        {
            error = "";
            m_Model.SetApplicationState(ApplicationStateEnum.LoadingFiles);
            if(!FileOperations.PopulateFileInformation(sDir, out error))
            {
                return false;
            }           
            m_Model.SetFileList(FileOperations.getFiles());
            m_Model.SetApplicationState(ApplicationStateEnum.Ready);

            return true;
        }

        public void SortFileList(DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None)
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

        #endregion

        #region DisplayMethods

        public string DetermineInstructions()
        {
            var control = m_Model.GetActiveUserControl();       
            if(control != null)
            {
                var controlName = control.Name;
                switch (controlName)
                {
                    case "findAndReplaceControls":
                        return "Please enter the text you would like to replace for all file names in the directory.";
                    case "findExtensionControls":
                        return "Please enter the extension you would like to find for all files in this directory.";
                    default:
                        return "Please select a directory to get started.";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(m_Model.GetFilePath()))
                {
                    return "Please select a directory to get started.";
                }
                else
                {
                    return "Please select an operation to get started.";
                }
            }
        }

        #endregion
    }
}
