using MyProject.DB;
using MyProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ManagerServices
{
    public class ProgramTypeManager
    {
        public List<ProgramType> GetAllProgramTypes() => DbProgramType.GetAllProgramTypes();
    }
}
