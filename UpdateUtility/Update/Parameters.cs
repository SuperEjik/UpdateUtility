using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.Update
{
    public static class Parameters
    {
        public static void parametrs(int time, string units, string datasource, string database, string username, string password, string name, string path)
        {
            if(time == 0 && units == "")
            {
                UpdateUtility.Settings.Update_interval.update_interval();
            }
            else
            {
                UpdateUtility.Settings.Update_interval.update_interval(time, units);
            }

            if(path == "")
            {
                UpdateUtility.Settings.BackUp.backup_parth();
            }
            else
            {
                UpdateUtility.Settings.BackUp.backup_parth(path);
            }

            UpdateUtility.Settings.Update_interval.update_interval(time, units);
            UpdateUtility.Settings.Connect.enter_in_systeam(datasource, database, username, password);
            UpdateUtility.Settings.Name.path_of_folders(name);
        }

        //UpdateUtility.SQL.Tabels.TablesChecking T = new UpdateUtility.SQL.Tabels.TablesChecking();
        //T.check();

        UpdateUtility.SQL.Tabels.TablesChecking.
    }
}
