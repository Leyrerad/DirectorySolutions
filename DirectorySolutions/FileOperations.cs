using DirectorySolutions.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public static class FileOperations
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<FileInfo> PopulateFileInformation(string path, out string errorMsg)
        {
            var fileList = new List<FileInfo>();
            errorMsg = "";
            try
            {
                string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    fileList.Add(new FileInfo(file));
                }

                return fileList;
            }
            catch (UnauthorizedAccessException e)
            {
                logger.Fatal(e);
                errorMsg = "An attempt was made to open an unathorized directory or file.";
                return null;
            }
            catch (Exception e)
            {
                logger.Fatal(e);
                errorMsg = e.Message;
                return null;
            }
        }

        public static bool FindAndReplaceOnFiles(List<FileInfo> files, string inString, string outString, out string error)
        {
            try
            {
                error = "";
                foreach (var file in files)
                {
                    if (file != null && !string.IsNullOrEmpty(file.Name) && file.Name.Contains(inString))
                    {
                        var newName = Path.GetFileNameWithoutExtension(file.Name).Replace(inString, outString).Trim() + file.Extension;
                        if (!string.Equals(file.FullName, Path.Combine(file.DirectoryName, newName)))
                        {
                            File.Move(file.FullName, Path.Combine(file.DirectoryName, newName));
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex);
                error = ex.Message;
                return false;
            }
        }

        public static bool FindAndReplaceOnParentDirectories(List<FileInfo> files, string inString, string outString, out string error)
        {
            try
            {
                error = "";
                List<string> directories = new List<string>();
                var drives = GetDriveInformation().Select(x => x.Name).Select(x => x.ToLower()).ToList();
                foreach (var file in files)
                {

                    if (!directories.Contains(file.Directory.FullName))
                    {
                        directories.Add(file.Directory.FullName);
                    }                            
                }

                foreach(var directory in directories)
                {
                    var dir = new DirectoryInfo(directory);

                    if(dir != null && !string.IsNullOrEmpty(dir.Name) && !string.IsNullOrEmpty(dir.FullName) && !drives.Select(x => x.Contains(inString.ToLower())).Any())
                    {
                        var newDirectoryName = dir.Name.Replace(inString, outString).Trim();
                        var dirs = dir.FullName.Split(Path.DirectorySeparatorChar).ToList();
                        if(dirs.Count > 1)
                        {
                            dirs.RemoveAt(dirs.Count - 1);
                        }
                        newDirectoryName = Path.Combine(string.Join(Path.DirectorySeparatorChar.ToString(), dirs), newDirectoryName);

                        if (!string.Equals(dir.FullName, newDirectoryName))
                        {
                            Directory.Move(dir.FullName, newDirectoryName);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex);
                error = ex.Message;
                return false;
            }
        }

        public static bool FindAndReplaceOnFullPath(List<FileInfo> files, string inString, string outString, out string error, out List<string> newSearchDirectories)
        {
            try
            {
                error = "";
                List<string> directories = new List<string>();
                newSearchDirectories = new List<string>();
                var drives = GetDriveInformation().Select(x => x.Name).Select(x => x.ToLower()).ToList();             
                
                foreach (var file in files)
                {

                    if (!directories.Contains(file.Directory.FullName))
                    {
                        directories.Add(file.Directory.FullName);
                    }
                }

                foreach (var directory in directories)
                {
                    List<string> preChangePathparts = new List<string>();
                    List<string> postChangePathparts = new List<string>();
                    var dir = new DirectoryInfo(directory);

                    if (dir != null && !string.IsNullOrEmpty(dir.Name) && !string.IsNullOrEmpty(dir.FullName))
                    {                        
                        var dirs = dir.FullName.Split(Path.DirectorySeparatorChar).ToList();

                        for(int i = 0; i < dirs.Count; i++)
                        {
                            if(ApiManager.SearchStringFound(inString, dirs[i]) && !drives.Select(x => x.Contains(inString.ToLower())).Any())
                            {
                                
                                preChangePathparts.Add(dirs[i]);
                                dirs[i] = dirs[i].Replace(inString, outString).Trim();
                                postChangePathparts.Add(dirs[i]);
                                var prePath = string.Join(Path.DirectorySeparatorChar.ToString(), preChangePathparts);
                                var postPath = string.Join(Path.DirectorySeparatorChar.ToString(), postChangePathparts);
                                if (!Directory.Exists(postPath))
                                {
                                    Directory.Move(prePath, postPath);
                                }
                                preChangePathparts[i] = dirs[i];
                            }
                            else
                            {
                                preChangePathparts.Add(dirs[i]);
                                postChangePathparts.Add(dirs[i]);
                            }                           
                        }

                        newSearchDirectories.Add(string.Join(Path.DirectorySeparatorChar.ToString(), postChangePathparts));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex);
                error = ex.Message;
                newSearchDirectories = null;
                return false;
            }
        }

        public static List<DriveInfo> GetDriveInformation()
        {
            return DriveInfo.GetDrives().ToList();
        }

        public static bool PreAndAppendFileNames(List<FileInfo> files, string prepend, string append, out string error)
        {
            try
            {
                error = "";
                foreach (var file in files)
                {
                    if (file != null && !string.IsNullOrEmpty(file.Name))
                    {
                        var newName = prepend + Path.GetFileNameWithoutExtension(file.Name) + append + Path.GetExtension(file.Name);
                        if (!string.Equals(file.FullName, Path.Combine(file.DirectoryName, newName)))
                        {
                            File.Move(file.FullName, Path.Combine(file.DirectoryName, newName));
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex);
                error = ex.Message;
                return false;
            }
        }

        public static bool RenameFilesByDirectory(List<FileInfo> files, int numberOfDirs, Tuple<string, string> seperatorTuple, DisplaySortOptionEnum sortBy, out string error, 
            out string displayFileName, bool incrementNames = false, int containsIncrements = 0, bool spaceBuffer = false, bool forDisplay = false)
        {
            try
            {
                error = "";
                displayFileName = "";
                int count = 0;

                if (spaceBuffer)
                {
                    seperatorTuple = Tuple.Create(" " + seperatorTuple.Item1 + " ", " " + seperatorTuple.Item2 + " ");
                }

                if (sortBy != DisplaySortOptionEnum.None)
                {
                    files = SortFileList(files, sortBy);
                }
                foreach (var file in files)
                {
                    var name = Path.GetFileNameWithoutExtension(file.Name);
                    string fullPath = file.FullName.Replace(file.Name, "");
                    var dirNames = fullPath.Split(Path.DirectorySeparatorChar).ToList().TakeLast(numberOfDirs + 1).ToList();
                    dirNames.Remove("");

                    for (int i = 0; i < dirNames.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(dirNames[i]))
                        {
                            dirNames[i] = seperatorTuple.Item1 + dirNames[i] + seperatorTuple.Item2;
                        }
                    }

                    var filePathCombined = string.Join("", dirNames);
                    var completedFileName = incrementNames ?
                        filePathCombined + name + seperatorTuple.Item1 + count.ToString()
                        + seperatorTuple.Item2 :
                        filePathCombined + name;
                    completedFileName = completedFileName.Trim() + file.Extension;

                    if (!forDisplay)
                    {
                        File.Move(file.FullName, Path.Combine(file.DirectoryName, completedFileName));
                    }
                    else
                    {
                        displayFileName = completedFileName;
                        break;
                    }
                  
                    count += 1;
                }

                return true;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex);
                error = ex.Message;
                displayFileName = "";
                return false;
            }
        }

        public static List<FileInfo> SortFileList(List<FileInfo> files, DisplaySortOptionEnum sortBy = DisplaySortOptionEnum.None)
        {
            switch (sortBy)
            {
                case (DisplaySortOptionEnum.DateAsc):
                    return files.OrderBy(x => x.LastWriteTime).ToList();
                case (DisplaySortOptionEnum.DateDesc):
                    return files.OrderByDescending(x => x.LastWriteTime).ToList();
                case (DisplaySortOptionEnum.SizeAsc):
                    return files.OrderBy(x => x.Length).ToList();
                case (DisplaySortOptionEnum.SizeDesc):
                    return files.OrderByDescending(x => x.Length).ToList();
                case (DisplaySortOptionEnum.NameAsc):
                    return files.OrderBy(x => x.Name).ToList();
                case (DisplaySortOptionEnum.NameDesc):
                    return files.OrderByDescending(x => x.Name).ToList();
                default:
                    return files;
            }
        }

        public static bool MoveFiles(List<FileInfo> files, string sDir, out string error)
        {
            error = "";
            try
            {
                foreach(var file in files)
                {
                    File.Move(file.FullName, Path.Combine(sDir, file.Name));
                }

                return false;
            }
            catch (Exception e)
            {
                logger.Fatal(e);
                error = e.Message;
                return false;
            }
        }

        public static List<FileInfo> FilterFileListBySearchOptions(List<FileInfo> files, FileSearch fileSearchOptions, out string error)
        {
            error = null;
            var filteredFiles = new List<FileInfo>();
            try
            {
                foreach (var file in files)
                {
                    var fFileName = Path.GetFileNameWithoutExtension(file.Name.ToLower().Trim());
                    var sFileName = fileSearchOptions.FileName.ToLower().Trim();
                    var extensions = fileSearchOptions.Extensions.ToLower().Trim().Split(',').ToList();                                       

                    if (!ApiManager.SearchStringFound(sFileName, fFileName)) { continue; }

                    var extFound = false;
                    foreach (var ext in extensions)
                    {
                        if (ApiManager.SearchStringFound(ext.Trim(), Path.GetExtension(file.Name).ToLower().Trim())) { extFound = true; break; }
                    }
                    if (!extFound) { continue; }

                    if(file.LastWriteTime < fileSearchOptions.DateModifiedStart || file.LastWriteTime > fileSearchOptions.DateModifiedEnd ||
                        file.Length < fileSearchOptions.FileSizeStart || file.Length > fileSearchOptions.FileSizeEnd)
                    {
                        continue;
                    }

                    if(!ApiManager.SearchStringFound(fileSearchOptions.Path, file.DirectoryName)) { continue; }

                    filteredFiles.Add(file);
                }

                return filteredFiles;
            }
            catch (Exception e)
            {
                error = e.Message;
                logger.Fatal(e);
                return null;
            }
        }

        public static List<FileInfo> AddFilesFromFileList(ListBox.ObjectCollection fileNames, out string error)
        {
            error = null;
            var files = new List<FileInfo>();
            try
            {
                foreach(var file in fileNames)
                {
                    if (File.Exists(file.ToString()))
                    {
                        files.Add(new FileInfo(file.ToString()));
                    }
                }

                return files;
            }
            catch (Exception e)
            {
                error = e.Message;
                logger.Fatal(e);
                return null;
            }

        }
    }
   
}
