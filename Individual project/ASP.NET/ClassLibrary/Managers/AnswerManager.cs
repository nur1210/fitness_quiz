﻿using Logic.Models;
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
        public AnswerManager(IDbAnswers repository)
        {
            _repository = repository;
        }
        public void AddAnswer(Answer a) => _repository.AddAnswer(a);
        public void RemoveAnswer(Answer a) => _repository.RemoveAnswer(a);
        public void EditAnswer(Answer a) => _repository.EditAnswer(a);
        public List<Answer> GetAllAnswers() => _repository.GetAllAnswers();
        public List<Answer> GetGetAllAnswersForQuestion(Question q) => _repository.GetGetAllAnswersForQuestion(q);
        public Answer GetAnswerByID(int answerID) => _repository.GetAnswerByID(answerID);

    }
}
