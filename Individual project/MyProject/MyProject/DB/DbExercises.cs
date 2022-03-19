using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class DbExercises
    {
        public static void AddExercise(Exercise exercise)
        {
            var conn = Connection.OpenConn();
            string sql = "INSERT INTO exercises (`program_id`, `name`, `reps`, `sets`) VALUES (@ProgramID, @Name, @Reps, @Sets)";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ProgramID", exercise.ProgramID), new MySqlParameter("Name", exercise.Name), new MySqlParameter("Reps", exercise.Reps), new MySqlParameter("Sets", exercise.Sets) });
            conn.Close();
        }

        public static void UpdateExercise(Exercise exercise)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE exercises SET name = @Name, reps = @Reps, sets = @Sets WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exercise.ID), new MySqlParameter("Name", exercise.Name), new MySqlParameter("Reps", exercise.Reps), new MySqlParameter("Sets", exercise.Sets) });
            conn.Close();
        }

        public static void DeleteExercise(Exercise exercise)
        {
            var conn = Connection.OpenConn();
            string sql = "DELETE FROM exercises WHERE id = @id";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exercise.ID) });
            conn.Close();
        }

        public static List<Exercise> GetAllExercises()
        {
            var conn = Connection.OpenConn();
            List<Exercise> list = new List<Exercise>();

            string sql = "SELECT * FROM exercises ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(conn, sql);

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    list.Add(new Exercise(rdr.GetInt32("id"),rdr.GetInt32("program_id"), rdr.GetString("name"),rdr.GetInt32("reps"), rdr.GetInt32("set")));
                }
            }
            rdr.Close();
            conn.Close();
            return list;
        }
    }
}
