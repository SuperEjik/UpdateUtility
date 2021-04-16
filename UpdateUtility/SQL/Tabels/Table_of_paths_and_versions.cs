using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.SQL.Tabels
{
    class Table_of_paths_and_versions : Tables
    {
        public override string create_table_query()
        {
            return "" +
                "CREATE TABLE PathAndVersions( " +
                "id_path_and_ver INT NOT NULL, " +
                "id_program INT NOT NULL, " +
                "name NVARCHAR(MAX), " +
                "ver NVARCHAR(MAX), " +
                "path NVARCHAR(MAX), " +
                "PRIMARY KEY(id_path_and_ver), " +
                "FOREIGN KEY (id_program)  REFERENCES Programs (id_program)" +
                ")";
        }
        public static void load() // загружаем конфигурацию по указанному в бд пути
        {
            using (SqlConnection connection = new SqlConnection(UpdateUtility.SQL.Settings.Connect.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM PathAndVersions";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string filename = reader.GetString(2);

                    string path = (string)reader.GetValue(3);

                    string ver = reader.GetString(4);

                    //string newPath = @"D:\учеба\4 курс\диплом\traning5_1\Upload files here\" + filename;//путь для выгрузки файла

                    //FileInfo fileInf = new FileInfo(path);

                    //FileInfo oldExists = new FileInfo(newPath);

                    //History H = new History();

                    //string verHistory = H.search_ver(filename);

                    //if (verHistory != ver)//если у пользователя старая версия или он ни разу не обновлялся
                    //{
                    //    Download(username, filename, ver, fileInf, newPath, H);

                    //    Backup save_old_conf = new Backup();

                    //    save_old_conf.save(filename, newPath, ver);
                    //}

                    //if (!(oldExists.Exists)) // если файлов вообще не существет у пользователя
                    //{
                    //    Download(username, filename, ver, fileInf, newPath, H);
                    //}

                }
                connection.Close();
            }
        }
    }
}
