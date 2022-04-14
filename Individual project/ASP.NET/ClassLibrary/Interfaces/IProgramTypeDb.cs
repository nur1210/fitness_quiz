using Logic.Models;

namespace Logic.Interfaces;

public interface IProgramTypeDb
{
    public List<ProgramType> GetAllProgramTypes();
}