using Logic.IDb;
using Logic.Interfaces;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbProgramType : IProgramTypeDb, IDbProgramType
    {
        public List<ProgramType> GetAllProgramTypes()
        {
            using (var conn = Connection.OpenConn())
            {
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
                return list;
            }
        }
    }
}
