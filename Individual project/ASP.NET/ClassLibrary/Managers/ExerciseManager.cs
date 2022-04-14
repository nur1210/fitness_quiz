using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class ExerciseManager
    {
        private readonly IDbExercises _repository;
        public ExerciseManager(IDbExercises repository)
        {
            _repository = repository;
        }
        public void AddExercise(Exercise e) => _repository.AddExercise(e);
        public void EditExercise(Exercise e) => _repository.EditExercise(e);
        public void RemoveExercise(Exercise e) => _repository.RemoveExercise(e);
        public List<Exercise> GetAllExercises() => _repository.GetAllExercises();
        public List<Exercise> GetAllExercisesForProgram(TrainingProgram p) => _repository.GetAllExercisesForProgram(p);
        public Exercise GetExerciseByID(int id) => _repository.GetExerciseByID(id);
    }
}
