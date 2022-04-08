using ClassLibrary.DB;
using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class ProgramManager
    {
        public void AddProgram(TrainingProgram program) => DbPrograms.AddProgram(program);
        public void EditProgram(TrainingProgram program) => DbPrograms.UpdateProgram(program);
        public void RemoveProgram(TrainingProgram program) => DbPrograms.DeleteProgram(program);
        public List<TrainingProgram> GetAllPrograms() => DbPrograms.GetAllPrograms();
        public int GetInsertedProgramID() => DbPrograms.GetInsertedProgramID();
        public TrainingProgram GetProgramByID(int id) => DbPrograms.GetProgramByID(id);
        public List<Answer> GetAllAnswersReferncedByProgram(int programID) => DbPrograms.GetAllAnswersReferncedByProgram(programID);

    }
}
