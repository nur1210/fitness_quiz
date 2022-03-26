using ClassLibrary.DB;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class ProgramTypeManager
    {
        public List<ProgramType> GetAllProgramTypes() => DbProgramType.GetAllProgramTypes();
    }
}
