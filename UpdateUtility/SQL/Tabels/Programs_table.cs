using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateUtility.SQL.Tabels
{
    class Programs_table : Tables
    {
        public override string create_table_query()
        {
            return "" +
                "CREATE TABLE Programs( " +
                "id_program INT NOT NULL, " +
                "name NVARCHAR(MAX) NOT NULL, " +
                "created_by NVARCHAR(MAX), " +
                "PRIMARY KEY(id_program)" +
                ")";
        }
    }
}
