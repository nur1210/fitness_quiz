using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class ProgramTypeManager
    {
        private readonly IDbProgramType _repository;
        public ProgramTypeManager(IDbProgramType repository)
        {
            _repository = repository;
        }
        public List<ProgramType> GetAllProgramTypes() => _repository.GetAllProgramTypes();
    }
}
