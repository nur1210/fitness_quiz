using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ManagerServices
{
    public class ExerciseManager
    {
        public void AddExercise(Exercise e) => DbExercises.AddExercise(e);
        public void EditExercise(Exercise e) => DbExercises.UpdateExercise(e);
        public void RemoveExercise(Exercise e) => DbExercises.DeleteExercise(e);
        public List<Exercise> GetAllExercises() => DbExercises.GetAllExercises();
    }
}
