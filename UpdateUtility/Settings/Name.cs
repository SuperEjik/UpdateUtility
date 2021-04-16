using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.Settings
{
    public static class Name
    {
        private static string finde_path(string catalog, string fileName)
        {
            string path="";

            try
            {
                string[] dirs = Directory.GetDirectories(catalog, fileName, SearchOption.TopDirectoryOnly);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                    Console.ReadLine();
                    //return dir;
                    path = dir;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return e.ToString();
            }

            return path;
        }


        public static void path_of_folders(string fileName)
        {
            string folderUpdate = @"\\192.168.15.1\данные";

            string updateFile = finde_path(folderUpdate, fileName);

            string dirName = DriveInfo.GetDrives().ToString();

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            string ro = dirInfo.Root.ToString();

            string programFile = finde_path(ro, fileName);

            //Update U = new Update();

            //U.load(programFile, updateFile, fileName);

        }
    }
}
