using Logic.Models;

namespace Logic.IDb;

public interface IDbProgramType
{
    List<ProgramType> GetAllProgramTypes();
}