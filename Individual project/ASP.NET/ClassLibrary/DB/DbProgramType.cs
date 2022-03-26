using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DB
{
    public static class DbProgramType
    {
        public static List<ProgramType> GetAllProgramTypes()
        {
            var conn = Connection.OpenConn();
            List<ProgramType> list = new List<ProgramType>();

            string sql = "SELECT * FROM program_type ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(conn, sql);

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    list.Add(new ProgramType(rdr.GetInt32(0), rdr.GetString(1)));
                }
            }
            rdr.Close();
            conn.Close();
            return list;
        }
    }
}
