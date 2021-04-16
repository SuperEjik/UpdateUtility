using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.Settings
{
    public static class BackUp
    {
        static internal string backupPath;

        static internal void backup_parth(string parth)
        {
            backupPath = parth;
        }

        static internal string backup_parth()
        {
            if (backupPath == null)
            {
                return @"C:\Backup";
            }
            return backupPath;
        }
    }
}
