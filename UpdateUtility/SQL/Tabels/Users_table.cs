using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.SQL.Tabels
{
    class Users_table : Tables
    {
        public override string create_table_query()
        {
            return "" +
                "CREATE TABLE Users( " +
                "user_id INT NOT NULL, " +
                "operating_system NVARCHAR(MAX) NOT NULL, " +
                "computer_name NVARCHAR(MAX) NOT NULL, " +
                "PRIMARY KEY(user_id)" +
                ")";
        }
    }
}
