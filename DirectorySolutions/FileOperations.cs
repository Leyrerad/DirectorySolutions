using DirectorySolutions.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch(UnauthorizedAccessException e)
            {
                logger.Fatal(e);
                errorMsg = "An attempt was made to open an unathorized directory or file.";
                return null;
            }
            catch(Exception e)
            {
                logger.Fatal(e);
                errorMsg = e.Message;
                return null;
            }
        }

        public static bool FindAndReplace(List<FileInfo> files, string inString, string outString, out string error)
        {
            try
            {
                error = "";
                foreach(var file in files)
                {
                    if(file != null && !string.IsNullOrEmpty(file.Name) && file.Name.Contains(inString))
                    {
                        var newName = file.Name.Replace(inString, outString);
                        if(!string.Equals(file.FullName, Path.Combine(file.DirectoryName, newName)))
                        {
                            File.Move(file.FullName, Path.Combine(file.DirectoryName, newName));
                        }
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                logger.Fatal(ex);
                error = ex.Message;
                return false;
            }
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
            bool incrementNames = false, int containsIncrements = 0, bool spaceBuffer = false)
        {
            try
            {
                error = "";
                int count = 0;

                if (spaceBuffer)
                {
                    seperatorTuple = Tuple.Create(" " + seperatorTuple.Item1 + " ", " " + seperatorTuple.Item2 + " ");
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
                        filePathCombined +  name + seperatorTuple.Item1 + count.ToString() 
                        + seperatorTuple.Item2:
                        filePathCombined +  name;
                    completedFileName = completedFileName.Trim() + file.Extension;

                    File.Move(file.FullName, Path.Combine(file.DirectoryName, completedFileName));
                    count += 1;
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

    }

   
}
