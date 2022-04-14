using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class QuestionManager : IQuestionDb, IDbQuestions
    {
        private readonly IDbQuestions _repository;

        public QuestionManager(IDbQuestions repository)
        {
            _repository = repository;
        }
        public void AddQuestion(Question q) => _repository.AddQuestion(q);
        public void EditQuestion(int questionID, string descpription) => _repository.EditQuestion(questionID, descpription);
        public void RemoveQuestion(int questionID) => _repository.RemoveQuestion(questionID);
        public List<Question> GetAllQuestions() => _repository.GetAllQuestions();
        public int GetNextQuestionID() => _repository.GetNextQuestionID();
        public int GetInsertedQuestionID() => _repository.GetInsertedQuestionID();
        public Question GetQuestionByID(int questionID) => _repository.GetQuestionByID(questionID);

    }
}
