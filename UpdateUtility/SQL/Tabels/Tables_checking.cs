using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.SQL.Tabels
{
    public class TablesChecking
    {
        static string[] nameTable = new string[] { "Programs", "Users", "PathAndVersions", "UserActions"};

        public void check()
        {
            for (int i = 0; i < nameTable.Length; i++)
            {
                if (!serch_table(nameTable[i]))
                {
                    switch (i)
                    {
                        case 0:
                            {
                                UpdateUtility.SQL.Tabels.Programs_table T = new UpdateUtility.SQL.Tabels.Programs_table();
                                T.create_table();
                                break;
                            }
                        case 1:
                            {
                                UpdateUtility.SQL.Tabels.Users_table T = new UpdateUtility.SQL.Tabels.Users_table();
                                T.create_table();
                                break;
                            }
                        case 2:
                            {
                                UpdateUtility.SQL.Tabels.Table_of_paths_and_versions T = new UpdateUtility.SQL.Tabels.Table_of_paths_and_versions();
                                T.create_table();
                                break;
                            }
                        case 3:
                            {
                                UpdateUtility.SQL.Tabels.Table_of_user_actions T = new UpdateUtility.SQL.Tabels.Table_of_user_actions();
                                T.create_table();
                                break;
                            }
                    }
                }
                //else { Console.WriteLine("такая таблица есть"); Console.ReadLine(); }
            }
        }

        public bool serch_table(string nameTable)
        {
            string sqlExpression = " SELECT name AS [Название таблицы] FROM sys.tables";
            
            using (SqlConnection connection = new SqlConnection(UpdateUtility.SQL.Settings.Connect.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (String.Format("{0}", reader[0]) == nameTable)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
