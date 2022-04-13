namespace Logic.Models;

public interface IExercise
{
    int ID { get; set; }
    int ProgramID { get; set; }
    string Name { get; set; }
    int Reps { get; set; }
    int Sets { get; set; }
}