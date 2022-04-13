using Logic.Models;

namespace Logic.Interfaces;

public interface IDbProgramType
{
    List<ProgramType> GetAllProgramTypes();
}