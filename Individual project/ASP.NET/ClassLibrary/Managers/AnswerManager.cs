using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class AnswerManager
    {
        private readonly IDbAnswers _repository;
        private readonly ScoreManager _scoreManager;

        public AnswerManager(IDbAnswers repository, ScoreManager scoreManager)
        {
            _repository = repository;
            _scoreManager = scoreManager;
        }
        public void AddAnswer(Answer a) => _repository.AddAnswer(a);
        public void RemoveAnswer(Answer a) => _repository.RemoveAnswer(a);
        public void EditAnswer(Answer a) => _repository.EditAnswer(a);
        public List<Answer> GetAllAnswers() => _repository.GetAllAnswers();
        public List<Answer> GetAllAnswersForQuestion(Question q) => _repository.GetAllAnswersForQuestion(q);
        public List<Answer> GetAllAnswersWithoutScoreForQuestion(Question q) => GetAllAnswersForQuestion(q).Where(x => x.ID != _scoreManager.GetAllScores().Select(s => s.QuestionOptionID).FirstOrDefault()).ToList();
        public Answer GetAnswerByID(int answerID) => _repository.GetAnswerByID(answerID);

    }
}
