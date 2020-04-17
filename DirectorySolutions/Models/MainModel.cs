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
        #region Event Handling

        public delegate void PathEventHandler(object sender, PathEventArgs args);
        public delegate void FilesEventEventHandler(object sender, FilesEventArgs args);
        public delegate void ControlEventHandler(object sender, ControlEventArgs args);
        public delegate void SortOptionEventHandler(object sender, SortOptionEventArgs args);
        public delegate void StateChangeEventHandler(object sender, StateChangeEventArgs args);
        public delegate void MovieListChangedEventHandler(object sender, MoviesEventArgs args);
        public delegate void SearchStringChangedEventHandler(object sender, SearchStringEventArgs args);
        public delegate void GridViewOptionChangedEventHandler(object sender, GridViewEventArgs args);
        public event GridViewOptionChangedEventHandler gridViewOptionChanged;
        public event SearchStringChangedEventHandler searchStringChanged;
        public event MovieListChangedEventHandler movieListChanged;
        public event StateChangeEventHandler appStateChanged;
        public event PathEventHandler filePathChanged;
        public event FilesEventEventHandler fileListChanged;
        public event ControlEventHandler activeControlChanged;
        public event SortOptionEventHandler sortOptionChanged;

        #endregion

        #region member variables

        private List<string> userControlsForFileOperations = new List<string>() { "FindAndReplaceControls", "RenameFileForPath", "FilterFiles", "MoveOrDelete", "FindDuplicates" };
        private List<string> userControlsForMovieOperations = new List<string>() { "MovieManagement" };
        private Dictionary<string, string> buttonToTextKeyPair = new Dictionary<string, string>()
        {
            { "btnOpenDir", "defaultPathTxt" },
            { "btnOpenFastPathDir", "fastPathTxt" },
            { "btnOpenDirMain", "filePath" },
            { "btnOpenPathMove", "movePathTxt" }

        };
        private List<string> tips = new List<string>()
        {
            "Tip: You can select the 'Save Directory(s)' option when opening a new directory to keep the files from the previous directory in your file list.",
            "Tip: You can double click on files in the File List Display to view the file details more easily and even change the file name or open the file contents.",
            "Tip: You can add 'Fast Paths' to your application settings from the options menu. These allow you to right click on any button that opens the directory explorer to quickly add a directory path instead.",
            "Tip: Select the 'Inverse Results' checkbox when filtering files to return all files containing the opposite of your filter requirements, such as all filenames NOT containing a certain keyword."
        };
        private List<string> userControlsForDirectoryOperations = new List<string>();
        private string searchString;
        private List<string> allFilePaths;
        private string genericErrorMessage;
        private List<FileInfo> files;
        private List<DirectoryInfo> directories;
        private List<Movie> movies;
        private UserControl activeControl;
        private DisplaySortOptionEnum filesSortedBy;
        private DisplaySortOptionEnum dirsSortedBy;
        private ApplicationStateEnum appState;
        private GridViewOptionEnum gridViewOption;

        #endregion

        public MainModel()
        {
            files = new List<FileInfo>();
            directories = new List<DirectoryInfo>();
            allFilePaths = new List<string>();
            filesSortedBy = DisplaySortOptionEnum.None;
            dirsSortedBy = DisplaySortOptionEnum.None;
            appState = ApplicationStateEnum.Ready;
            gridViewOption = GridViewOptionEnum.Files;
        }

        #region Display

        public void SetGridViewOption(GridViewOptionEnum gridViewOption)
        {
            this.gridViewOption = gridViewOption;
            RaiseGridViewChangedEvent(gridViewOption, movies, files, directories);
        }

        public GridViewOptionEnum GetGridViewOption()
        {
            return gridViewOption;
        }

        public class GridViewEventArgs : EventArgs
        {
            public GridViewOptionEnum Option;
            public List<Movie> Movies { get; set; }
            public List<FileInfo> Files { get; set; }
            public List<DirectoryInfo> Directories { get; set; }
            public GridViewEventArgs(GridViewOptionEnum option, List<Movie> movies, List<FileInfo> files, List<DirectoryInfo> directories)
            {
                Option = option;
                Movies = movies;
                Files = files;
                Directories = directories;
            }
        }

        public void RaiseGridViewChangedEvent(GridViewOptionEnum option, List<Movie> movies, List<FileInfo> files, List<DirectoryInfo> directories)
        {
            gridViewOptionChanged(this, new GridViewEventArgs(option, movies, files, directories));
        }

        #endregion

        #region filePath

        public void SetActiveFilePath(string value)
        {
            if (!allFilePaths.Contains(value))
            {
                allFilePaths.Add(value);
                RaiseFilePathChangedEvent(allFilePaths);
            }
        }

        public void ClearFilePaths()
        {
            allFilePaths.Clear();
        }

        public void ReplaceFilePaths(List<string> filePaths, bool raiseEvent)
        {
            allFilePaths = filePaths;
            if (raiseEvent)
            {
                RaiseFilePathChangedEvent(filePaths);
            }
        }

        public List<string> GetAllFilePaths()
        {
            return allFilePaths;
        }

        public class PathEventArgs : EventArgs
        {
            public List<string> AllPaths { get; set; }
            public PathEventArgs(List<string> allPaths)
            {
                AllPaths = allPaths;
            }
        }

        public void RaiseFilePathChangedEvent(List<string> allFilePaths)
        {
            filePathChanged(this, new PathEventArgs(allFilePaths));
        }               

        #endregion

        #region Search String

        public void SetSearchString(string search)
        {
            searchString = search;
            RaiseSearchStringChangedEvent(search);
        }

        public string GetSearchString()
        {
            return searchString;
        }

        public class SearchStringEventArgs : EventArgs
        {
            public string Data { get; set; }
            public SearchStringEventArgs(string data)
            {
                Data = data;
            }
        }

        public void RaiseSearchStringChangedEvent(string search)
        {
            searchStringChanged(this, new SearchStringEventArgs(search));
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

        public void SetFileList(List<FileInfo> fileList, bool raiseEvent)
        {
            files = fileList;
            if (raiseEvent)
            {
                RaiseFileListChangedEvent(fileList);
            }
        }

        public List<FileInfo> GetFiles()
        {
            return files;
        }               

        public void ReplaceFile(FileInfo file, bool raiseEvent)
        {
            files[files.FindIndex(x => x.FullName == file.FullName)] = file;
            if (raiseEvent)
            {
                RaiseFileListChangedEvent(files);
            }
        }

        public void AddFilesToFileList(List<FileInfo> fileList, bool raiseEvent)
        {
            files.AddRange(fileList);
            if (raiseEvent)
            {
                RaiseFileListChangedEvent(files);
            }
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

        #region Movie List

        public void SetMovieList(List<Movie> movies, bool raiseEvent)
        {
            this.movies = movies;
            if (raiseEvent)
            {
                RaiseMovieListChangedEvent(movies);
            }         
        }

        public List<Movie> GetMovieList()
        {
            return movies;
        }

        public void AddMovieToList(Movie movie)
        {
            movies.Add(movie);
            RaiseMovieListChangedEvent(movies);
        }

        public void ClearMovieList()
        {
            movies.Clear();
        }

        public class MoviesEventArgs : EventArgs
        {
            public List<Movie> Data { get; set; }
            public MoviesEventArgs(List<Movie> data)
            {
                Data = data;
            }
        }

        public void RaiseMovieListChangedEvent(List<Movie> movies)
        {
            movieListChanged(this, new MoviesEventArgs(movies));
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

        public string GetSumFileLengths(GridViewOptionEnum option)
        {
            try
            {
                switch (option)
                {
                    case GridViewOptionEnum.Files:
                        return SizeSuffix(files.Sum(x => x.Length));
                    case GridViewOptionEnum.Movies:
                        return SizeSuffix(movies.Sum(x => x.FileSize));
                    default:
                        return "N/A";
                }               
            }
            catch(Exception e)
            {
                genericErrorMessage = e.Message;
                return null;
            }
           
        }

        public static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public string SizeSuffix(Int64 value, int decimalPlaces = 2)
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

        public double GetFileCount(GridViewOptionEnum option)
        {
            switch (option)
            {
                case GridViewOptionEnum.Files:
                    return files.Count();
                case GridViewOptionEnum.Movies:
                    return movies.Count();
                default:
                    return 0;
            }
            
        }

        public Tuple<string, string> GetFileNameByPathSeperatorTuple(NameByPathSeperatorEnum seperator)
        {
            switch (seperator)
            {
                case NameByPathSeperatorEnum.Underscore:
                    return Tuple.Create("_", "_");
                case NameByPathSeperatorEnum.Dash:
                    return Tuple.Create("-", "-");
                case NameByPathSeperatorEnum.Space:
                    return Tuple.Create(" ", " ");
                case NameByPathSeperatorEnum.Brackets:
                    return Tuple.Create("[", "]");
                case NameByPathSeperatorEnum.Parentheses:
                    return Tuple.Create("(", ")");
                default:
                    return Tuple.Create("_", "_");
            }
        }

        public GridViewOptionEnum DetermineGridViewOption(UserControl control)
        {
            if (userControlsForMovieOperations.Contains(control.Name))
            {
                return GridViewOptionEnum.Movies;
            }

            if (userControlsForDirectoryOperations.Contains(control.Name))
            {
                return GridViewOptionEnum.Directories;
            }

            if (userControlsForFileOperations.Contains(control.Name))
            {
                return GridViewOptionEnum.Files;
            }

            return GridViewOptionEnum.Files;
        }

        #endregion

        #region fast paths

        public Dictionary<string, string> GetButtonToTextKeyPair()
        {
            return buttonToTextKeyPair;
        }

        #endregion

        #region tips

        public List<string> GetTips()
        {
            return tips;
        }

        public string GetRandomTip()
        {
            Random rnd = new Random();
            return tips.ElementAt(rnd.Next(1, tips.Count));
        }

        #endregion

    }

    #region enums

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
        [Description("File Operation In Progress...")]
        FileOperation
       
    }

    public enum NameByPathSeperatorEnum
    {
        Underscore,
        Dash,
        Space,
        Brackets,
        Parentheses
    }   

    public enum GridViewOptionEnum
    {
        Files,
        Directories,
        Movies
    }

    #endregion

    #region Helper classes

    public class FileSearch
    {
        public string FileName { get; set; }
        public DateTime DateModifiedStart { get; set; }
        public DateTime DateModifiedEnd { get; set; }
        public string Extensions { get; set; }
        public double FileSizeStart { get; set; }
        public double FileSizeEnd { get; set; }
        public string Path { get; set; }
        public bool InverseResults { get; set; }
    }

    #endregion

    public interface IMainModel
    {
        string GetRandomTip();
        
        void ClearFilePaths();

        List<string> GetAllFilePaths();

        void SetFileList(List<FileInfo> fileList, bool raiseEvent);

        List<FileInfo> GetFiles();

        void SetActiveControl(UserControl control);

        UserControl GetActiveUserControl();

        void SetSortedByEnum(DisplaySortOptionEnum sortedBy, bool isDir);

        DisplaySortOptionEnum GetSortedBy(bool isDir);

        void SetApplicationState(ApplicationStateEnum state);

        ApplicationStateEnum GetApplicationState();

        void RaiseFileListChangedEvent(List<FileInfo> fileList);

        void RaiseFilePathChangedEvent(List<string> allFilePaths);

        Tuple<string, string> GetFileNameByPathSeperatorTuple(NameByPathSeperatorEnum seperator);

        void SetMovieList(List<Movie> movies, bool raiseEvent);

        List<Movie> GetMovieList();

        void AddMovieToList(Movie movie);

        void ClearMovieList();

        void SetSearchString(string search);

        string GetSearchString();

        void SetGridViewOption(GridViewOptionEnum gridViewOption);

        GridViewOptionEnum GetGridViewOption();

        GridViewOptionEnum DetermineGridViewOption(UserControl control);

        void AddFilesToFileList(List<FileInfo> fileList, bool raiseEvent);

        void ReplaceFilePaths(List<string> filePaths, bool raiseEvent);

        string SizeSuffix(Int64 value, int decimalPlaces = 2);

        Dictionary<string, string> GetButtonToTextKeyPair();

    }
        
}
