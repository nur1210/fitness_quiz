using Logic.Models;

namespace Logic.Managers;

public interface IProgramDb
{
    public void AddProgram(TrainingProgram program);
    public void EditProgram(TrainingProgram program);
    public void RemoveProgram(TrainingProgram program);
    public List<TrainingProgram> GetAllPrograms();
    public int GetInsertedProgramID();
    public TrainingProgram GetProgramByID(int id);
    public List<Answer> GetAllAnswersReferncedByProgram(int programID);
}