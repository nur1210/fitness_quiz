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
        public void AddProgram(TrainigProgram program) => DbPrograms.AddProgram(program);
        public void EditProgram(TrainigProgram program) => DbPrograms.UpdateProgram(program);
        public void RemoveProgram(TrainigProgram program) => DbPrograms.DeleteProgram(program);
        public List<TrainigProgram> GetAllPrograms() => DbPrograms.GetAllPrograms();
        public int GetInsertedProgramID() => DbPrograms.GetInsertedProgramID();
        public TrainigProgram GetProgramByID(int id) => DbPrograms.GetProgramByID(id);
        public List<Answer> GetAllAnswersReferncedByProgram(int programID) => DbPrograms.GetAllAnswersReferncedByProgram(programID);

    }
}
