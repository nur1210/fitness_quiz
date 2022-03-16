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
            string sql = "INSERT INTO exercises (`program_id`, `name`, `reps`, `sets`) VALUES (@ProgramID, @Name, @Reps, @Sets)";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("ProgramID", exercise.ProgramID), new MySqlParameter("Name", exercise.Name), new MySqlParameter("Reps", exercise.Reps), new MySqlParameter("Sets", exercise.Sets) });
        }

        public static void UpdateExercise(Exercise exercise)
        {
            string sql = "UPDATE exercises SET name = @Name, reps = @Reps, sets = @Sets WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exercise.ID), new MySqlParameter("Name", exercise.Name), new MySqlParameter("Reps", exercise.Reps), new MySqlParameter("Sets", exercise.Sets) });
        }

        public static void DeleteExercise(Exercise exercise)
        {
            string sql = "DELETE FROM exercises WHERE id = @id";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exercise.ID) });
        }

        public static List<Exercise> GetAllExercises()
        {
            List<Exercise> list = new List<Exercise>();

            string sql = "SELECT * FROM exercises ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(Connection.Conn, sql);

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    list.Add(new Exercise(rdr.GetInt32("id"),rdr.GetInt32("program_id"), rdr.GetString("name"),rdr.GetInt32("reps"), rdr.GetInt32("set")));
                }
            }
            return list;
        }
    }
}
