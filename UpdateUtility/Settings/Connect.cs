using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.Settings
{
    public static class Connect
    {
        internal static string Datasource { get; set; }
        internal static string Database { get; set; }
        internal static string Username { get; set; }
        internal static string Password { get; set; }
        internal static string ConnectionString { get; set; }

        public static string enter_in_systeam(string datasource, string database, string username, string password)
        {

            Datasource = datasource;
            Database = database;
            Username = username;
            Password = password;

            ConnectionString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            return ConnectionString;
        }
    }
}
