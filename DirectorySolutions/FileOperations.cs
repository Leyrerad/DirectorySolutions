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
        public static List<FileInfo> Files = new List<FileInfo>();

        public static void DirSearchRecursive(string path)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Files.Add(new FileInfo(f));
                    }

                    DirSearchRecursive(d);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt);
            }
        }

        public static void DirSearch(string path)
        {
            try
            {
                foreach (string f in Directory.GetFiles(path))
                {
                    Files.Add(new FileInfo(f));
                }
             
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt);
            }
        }

        public static bool FindAndReplace(List<FileInfo> files, string inString, string outString)
        {
            try
            {
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
                return false;
            }
        }

        public static List<FileInfo> getFiles()
        {
            return Files;
        }

        public static bool clearFiles()
        {
            try
            {
                Files.Clear();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
