using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DB
{
    public static class DbPrograms
    {
        public static void AddProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO programs (description, program_type, rest_between_sets, min_age, max_age) VALUES (@Description, @Type, @Rest, @MinAge, @MaxAge)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description), 
                    new MySqlParameter("Type", program.TypeID), new MySqlParameter("Rest", program.RestBetweenSets), 
                    new MySqlParameter("MinAge", program.AgeRange.Min()), new MySqlParameter("MaxAge", program.AgeRange.Max()) });
            }
        }

        public static void UpdateProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE programs SET description = @Description, program_type = @Type, rest_between_sets = @Rest, " +
                    "min_age = @MinAge, max_age = @MaxAge WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description),
                    new MySqlParameter("Type", program.TypeID), new MySqlParameter("Rest", program.RestBetweenSets), 
                    new MySqlParameter("MinAge", program.AgeRange.Min()), new MySqlParameter("MaxAge", program.AgeRange.Max()), 
                    new MySqlParameter("ID", program.ID) });
            }
        }

        public static void DeleteProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM programs WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", program.ID) });
            }
        }

        public static List<TrainingProgram> GetAllPrograms()
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

        public static int GetInsertedProgramID()
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id FROM programs ORDER BY id DESC LIMIT 1;";
                var result = MySqlHelper.ExecuteScalar(conn, sql);
                int id = -1;
                if (result is not null)
                {
                    id = Convert.ToInt32(result);
                }
                return id;
            }
        }

        public static TrainingProgram GetProgramByID(int programID)
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

        public static List<Answer> GetAllAnswersReferncedByProgram(int programID)
        {
            List<Answer> list = new List<Answer>();

            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT a.id, a.question_id, a.description, a.program_id FROM answers as a inner join programs as p " +
                    "on a.program_id = p.id WHERE p.id = @ID;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] {new MySqlParameter("ID", programID)});

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
