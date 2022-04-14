using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class ProgramManager
    {
        private readonly IDbPrograms _repository;
        public ProgramManager(IDbPrograms repository)
        {
            _repository = repository;
        }
        public void AddProgram(TrainingProgram program) => _repository.AddProgram(program);
        public void EditProgram(TrainingProgram program) => _repository.EditProgram(program);
        public void RemoveProgram(TrainingProgram program) => _repository.RemoveProgram(program);
        public List<TrainingProgram> GetAllPrograms() => _repository.GetAllPrograms();
        public int GetInsertedProgramID() => _repository.GetInsertedProgramID();
        public TrainingProgram GetProgramByID(int id) => _repository.GetProgramByID(id);

    }
}
