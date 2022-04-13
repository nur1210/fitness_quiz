using System.Linq;
using Logic.Interfaces;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbPrograms : IProgramDb, IDbPrograms
    {
        public void AddProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO programs (description, program_type, rest_between_sets, min_age, max_age) VALUES (@Description, @Type, @Rest, @MinAge, @MaxAge)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description),
                    new MySqlParameter("Type", program.TypeID), new MySqlParameter("Rest", program.RestBetweenSets),
                    new MySqlParameter("MinAge", Enumerable.Min((IEnumerable<int>) program.AgeRange)), new MySqlParameter("MaxAge", Enumerable.Max((IEnumerable<int>) program.AgeRange)) });
            }
        }

        public void EditProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE programs SET description = @Description, program_type = @Type, rest_between_sets = @Rest, " +
                    "min_age = @MinAge, max_age = @MaxAge WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description),
                    new MySqlParameter("Type", program.TypeID), new MySqlParameter("Rest", program.RestBetweenSets),
                    new MySqlParameter("MinAge", Enumerable.Min((IEnumerable<int>) program.AgeRange)), new MySqlParameter("MaxAge", Enumerable.Max((IEnumerable<int>) program.AgeRange)),
                    new MySqlParameter("ID", program.ID) });
            }
        }

        public void RemoveProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM programs WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", program.ID) });
            }
        }

        public List<TrainingProgram> GetAllPrograms()
        {
            List<TrainingProgram> list = new List<TrainingProgram>();

            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id, description, program_type FROM programs ORDER BY id;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        list.Add(new TrainingProgram(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2)));
                    }
                }
                rdr.Close();
                return list;
            }
        }

        public int GetInsertedProgramID()
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id FROM programs ORDER BY id DESC LIMIT 1;";
                var result = MySqlHelper.ExecuteScalar(conn, sql);
                int id = -1;
                if (result is not null)
                {
                    id = Convert.ToInt32((object?) result);
                }
                return id;
            }
        }

        public TrainingProgram GetProgramByID(int programID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id, description, program_type FROM programs WHERE id = @ID";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", programID) });

                while (rdr.Read())
                {
                    if (rdr is not null)
                    {
                        return new TrainingProgram(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
                    }
                }
                return null;
            }
        }

        public List<Answer> GetAllAnswersReferncedByProgram(int programID)
        {
            List<Answer> list = new List<Answer>();

            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT a.id, a.question_id, a.description, a.program_id FROM question_options as a inner join programs as p " +
                    "on a.program_id = p.id WHERE p.id = @ID;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", programID) });

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        list.Add(new Answer(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetInt32(3)));
                    }
                }
                rdr.Close();
                return list;
            }
        }
    }
}
