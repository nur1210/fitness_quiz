﻿using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbExercises : IDbExercises
    {
        public void AddExercise(Exercise exercise)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO exercises (`program_id`, `name`, `reps`, `sets`) VALUES (@ProgramID, @Name, @Reps, @Sets)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ProgramID", exercise.ProgramID), new MySqlParameter("Name", exercise.Name), new MySqlParameter("Reps", exercise.Reps), new MySqlParameter("Sets", exercise.Sets) });
            }
        }

        public void EditExercise(Exercise exercise)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE exercises SET name = @Name, reps = @Reps, sets = @Sets WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exercise.ID), new MySqlParameter("Name", exercise.Name), new MySqlParameter("Reps", exercise.Reps), new MySqlParameter("Sets", exercise.Sets) });
            }
        }

        public void RemoveExercise(Exercise exercise)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM exercises WHERE id = @id";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exercise.ID) });
            }
        }

        public List<Exercise> GetAllExercises()
        {
            using (var conn = Connection.OpenConn())
            {
                List<Exercise> exercisesList = new List<Exercise>();

                string sql = "SELECT * FROM exercises ORDER BY id;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        exercisesList.Add(new Exercise(rdr.GetInt32("id"), rdr.GetInt32("program_id"), rdr.GetString("name"), rdr.GetInt32("reps"), rdr.GetInt32("set")));
                    }
                }
                rdr.Close();
                return exercisesList;
            }
        }

        public List<Exercise> GetAllExercisesForProgram(TrainingProgram program)
        {
            using (var conn = Connection.OpenConn())
            {
                List<Exercise> exercisesList = new List<Exercise>();

                string sql = "SELECT * FROM exercises WHERE program_id = @ID";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", program.ID) });

                while (rdr.Read())
                {
                    if (rdr is not null)
                    {
                        exercisesList.Add(new Exercise(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetInt32(4)));
                    }
                }
                rdr.Close();
                return exercisesList;
            }
        }

        public Exercise GetExerciseByID(int exerciseID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT * FROM exercises WHERE id = @ID";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", exerciseID) });

                while (rdr.Read())
                {
                    if (rdr is not null)
                    {
                        return new Exercise(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetInt32(4));
                    }
                }
                return null;
            }
        }
    }
}
