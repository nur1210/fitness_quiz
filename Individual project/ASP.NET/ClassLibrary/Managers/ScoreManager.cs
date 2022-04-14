using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;
using Logic.Models;

namespace Logic.Managers
{
    public class ScoreManager
    {
        private readonly IDbQuestionOptionScore _repository;
        public ScoreManager(IDbQuestionOptionScore repository)
        {
            _repository = repository;
        }

        public void AddScore(Score s) => _repository.AddScore(s);
        public void UpdateScore(Score s) => _repository.UpdateScore(s);
        public void DeleteScore(Score s) => _repository.DeleteScore(s);
        public List<Score> GetAllScores() => _repository.GetAllScores();

        public List<Score> GetScoresForProgramByProgramID(int programID) =>
            _repository.GetAllScores().Where(x => x.ProgramID == programID).ToList();
    }
}
