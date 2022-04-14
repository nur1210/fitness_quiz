using Logic.Models;

namespace Logic.Interfaces;

public interface IExerciseDb
{
    public void AddExercise(Exercise e);
    public void EditExercise(Exercise e);
    public void RemoveExercise(Exercise e);
    public List<Exercise> GetAllExercises();
    public List<Exercise> GetAllExercisesForProgram(TrainingProgram p);
    public Exercise GetExerciseByID(int id);
}