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
        public static List<FileInformation> Files = new List<FileInformation>();

        public static void DirSearchRecursive(string path)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    var directory = new DirectoryInfo(d);

                    foreach (string f in Directory.GetFiles(d))
                    {
                        var fileInfo = new FileInfo(f);

                        Files.Add(new FileInformation()
                        {
                            ParentDirectory = directory,
                            FileInfo = fileInfo
                        });
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
                    var fileInfo = new FileInfo(f);

                    Files.Add(new FileInformation()
                    {
                        ParentDirectory = new DirectoryInfo(path),
                        FileInfo = fileInfo
                    });
                }
             
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt);
            }
        }

        public static List<FileInformation> getFiles()
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

    public class FileInformation
    {
        public DirectoryInfo ParentDirectory { get; set; }
        public FileInfo FileInfo { get; set; }
     
    }
}
