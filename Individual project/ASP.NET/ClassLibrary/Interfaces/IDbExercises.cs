using Logic.Models;

namespace Logic.Interfaces;

public interface IDbExercises
{
    void AddExercise(Exercise exercise);
    void EditExercise(Exercise exercise);
    void RemoveExercise(Exercise exercise);
    List<Exercise> GetAllExercises();
    List<Exercise> GetAllExercisesForProgram(TrainingProgram program);
    Exercise GetExerciseByID(int exerciseID);
}