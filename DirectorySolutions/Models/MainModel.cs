using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySolutions.Models
{
    public class MainModel : IMainModel
    {
        public delegate void PathEventEventHandler(object sender, PathEventArgs args);
        public delegate void FilesEventEventHandler(object sender, FilesEventArgs args);
        public delegate void ControlEventHandler(object sender, ControlEventArgs args);
        public delegate void SortOptionEventHandler(object sender, SortOptionEventArgs args);
        public delegate void StateChangeEventHandler(object sender, StateChangeEventArgs args);
        public event StateChangeEventHandler appStateChanged;
        public event PathEventEventHandler filePathChanged;
        public event FilesEventEventHandler fileListChanged;
        public event ControlEventHandler activeControlChanged;
        public event SortOptionEventHandler sortOptionChanged;        

        private string filePath;
        private string genericErrorMessage;
        private List<FileInfo> files;
        private List<DirectoryInfo> directories;
        private UserControl activeControl;
        private DisplaySortOptionEnum filesSortedBy;
        private DisplaySortOptionEnum dirsSortedBy;
        private ApplicationStateEnum appState;
        
        public MainModel()
        {
            filePath = "";
            files = new List<FileInfo>();
            directories = new List<DirectoryInfo>();
            filesSortedBy = DisplaySortOptionEnum.None;
            dirsSortedBy = DisplaySortOptionEnum.None;
            appState = ApplicationStateEnum.Ready;
        }

        #region filePath

        public void SetFilePath(string value)
        {
            filePath = value;
            RaiseFilePathChangedEvent(value);
        }

        public string GetFilePath()
        {
            return filePath;
        }

        public class PathEventArgs : EventArgs
        {
            public string Data { get; set; }
            public PathEventArgs(string data)
            {
                Data = data;
            }
        }

        public void RaiseFilePathChangedEvent(string filePath)
        {
            filePathChanged(this, new PathEventArgs(filePath));
        }

        #endregion

        #region AppState

        public void SetApplicationState(ApplicationStateEnum state)
        {
            appState = state;
            RaiseAppStateChangedEvent(state);
        }

        public ApplicationStateEnum GetApplicationState()
        {
            return appState;
        }

        public class StateChangeEventArgs : EventArgs
        {
            public ApplicationStateEnum Data { get; set; }
            public StateChangeEventArgs(ApplicationStateEnum data)
            {
                Data = data;
            }
        }

        public void RaiseAppStateChangedEvent(ApplicationStateEnum state)
        {
            appStateChanged(this, new StateChangeEventArgs(state));
        }

        #endregion

        #region fileList

        public void SetFileList(List<FileInfo> fileList)
        {
            files = fileList;
            RaiseFileListChangedEvent(fileList);
        }

        public List<FileInfo> GetFiles()
        {
            return files;
        }

        public class FilesEventArgs : EventArgs
        {
            public List<FileInfo> Data { get; set; }
            public FilesEventArgs(List<FileInfo> data)
            {
                Data = data;
            }
        }

        public void RaiseFileListChangedEvent(List<FileInfo> fileList)
        {
            fileListChanged(this, new FilesEventArgs(fileList));
        }

        #endregion

        #region ActiveControl

        public void SetActiveControl(UserControl control)
        {
            activeControl = control;
            RaiseActiveControlChangedEvent(control);
        }

        public UserControl GetActiveUserControl()
        {
            return activeControl;
        }

        public class ControlEventArgs : EventArgs
        {
            public UserControl Data { get; set; }
            public ControlEventArgs(UserControl data)
            {
                Data = data;
            }
        }

        public void RaiseActiveControlChangedEvent(UserControl control)
        {
            activeControlChanged(this, new ControlEventArgs(control));
        }

        #endregion

        #region sorting

        public void SetSortedByEnum(DisplaySortOptionEnum sortedBy, bool isDir)
        {
            if (isDir)
            {
                dirsSortedBy = sortedBy;            
            }
            else
            {
                filesSortedBy = sortedBy;
            }
        }

        public DisplaySortOptionEnum GetSortedBy(bool isDir)
        {
            return (isDir == true) ? dirsSortedBy : filesSortedBy; 
        }

        public class SortOptionEventArgs : EventArgs
        {
            public DisplaySortOptionEnum Data { get; set; }
            public bool IsDir { get; set; }
            public SortOptionEventArgs(DisplaySortOptionEnum data, bool dir)
            {
                Data = data;
                IsDir = dir;
            }
        }

        public void RaiseSortingChangedEvent(DisplaySortOptionEnum sortedBy, bool isDir)
        {
            sortOptionChanged(this, new SortOptionEventArgs(sortedBy, isDir));
        }


        #endregion

        #region Operations

        public string GetErrorMessage()
        {
            return genericErrorMessage;
        }

        public string GetSumFileLengths()
        {
            try
            {
                return SizeSuffix(files.Sum(x => x.Length));
            }
            catch(Exception e)
            {
                genericErrorMessage = e.Message;
                return null;
            }
           
        }

        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value, int decimalPlaces = 2)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        public double GetFileCount()
        {
            return files.Count();
        }

        #endregion

    }

    public enum DisplaySortOptionEnum
    {
        [Description("Not Sorted")]
        None,
        [Description("Size Ascending")]
        SizeAsc,
        [Description("Size Descending")]
        SizeDesc,
        [Description("Name Ascending")]
        NameAsc,
        [Description("Name Descending")]
        NameDesc,
        [Description("Date Ascending")]
        DateAsc,
        [Description("Date Descending")]
        DateDesc
    }

    public enum ApplicationStateEnum
    {
        [Description("Ready")]
        Ready,
        [Description("Loading Files...")]
        LoadingFiles,
        [Description("Sorting Files...")]
        SortingFiles,
       
    }

    public interface IMainModel
    {
        void SetFilePath(string value);

        string GetFilePath();

        void SetFileList(List<FileInfo> fileList);

        List<FileInfo> GetFiles();

        void SetActiveControl(UserControl control);

        UserControl GetActiveUserControl();

        void SetSortedByEnum(DisplaySortOptionEnum sortedBy, bool isDir);

        DisplaySortOptionEnum GetSortedBy(bool isDir);

        void SetApplicationState(ApplicationStateEnum state);

        ApplicationStateEnum GetApplicationState();

    }


        
}
