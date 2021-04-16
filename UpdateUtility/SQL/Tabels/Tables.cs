using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.SQL.Tabels
{
    abstract class Tables
    {
        public abstract string create_table_query();

        public void create_table()
        {
            using (SqlConnection connection = new SqlConnection(UpdateUtility.Settings.Connect.ConnectionString))
            {
                SqlCommand sqlCom = new SqlCommand(create_table_query(), connection);

                connection.Open();

                sqlCom.ExecuteNonQuery();

                connection.Close();

                connection.Open();
            }
        }
    }
}
