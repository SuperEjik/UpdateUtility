using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.SQL.Tabels
{
    class Table_of_user_actions : Tables
    {
        public override string create_table_query()
        {
            return "" +
                "CREATE TABLE UserActions( " +
                "id_user_actions INT NOT NULL, " +
                "user_id INT NOT NULL, " +
                "id_path_and_ver INT NOT NULL, " +
                "downloaded_version NVARCHAR(MAX), " +
                "errors NVARCHAR(MAX), " +
                "date NVARCHAR(MAX), " +
                "PRIMARY KEY(id_path_and_ver), " +
                "FOREIGN KEY (user_id) REFERENCES Users (user_id), " +
                "FOREIGN KEY (id_path_and_ver) REFERENCES PathAndVersions (id_path_and_ver)" +
                ")";
        }
    }
}
