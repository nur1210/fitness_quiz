using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class AnswerManager : IAnswerDb
    {
        private readonly IDbAnswers _repository;
        public AnswerManager(IDbAnswers repository)
        {
            _repository = repository;
        }
        public void AddAnswer(Answer a) => _repository.AddAnswer(a);
        public void RemoveAnswer(Answer a) => _repository.RemoveAnswer(a);
        public void EditAnswer(Answer a) => _repository.EditAnswer(a);
        public List<Answer> GetAllAnswers() => _repository.GetAllAnswers();
        public List<Answer> GetGetAllAnswersForQuestion(Question q) => _repository.GetGetAllAnswersForQuestion(q);
        public void AddProgramReference(int answerID, int programID) => _repository.AddProgramReference(answerID, programID);
        public void RemoveProgramReference(int answerID) => _repository.RemoveProgramReference(answerID);
        public bool HasProgramReference(int answerID) => _repository.HasProgramReference(answerID);
        public int GetProgramReference(int answerID) => _repository.GetProgramReference(answerID);
    }
}
