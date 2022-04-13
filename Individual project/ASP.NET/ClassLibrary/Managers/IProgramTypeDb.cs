using Logic.Models;

namespace Logic.Managers;

public interface IProgramTypeDb
{
    public List<ProgramType> GetAllProgramTypes();
}