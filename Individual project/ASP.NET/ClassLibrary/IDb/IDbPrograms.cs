using Logic.Models;

namespace Logic.IDb;

public interface IDbPrograms
{
    void AddProgram(TrainingProgram program);
    void EditProgram(TrainingProgram program);
    void RemoveProgram(TrainingProgram program);
    List<TrainingProgram> GetAllPrograms();
    int GetInsertedProgramID();
    TrainingProgram GetProgramByID(int programID);
}