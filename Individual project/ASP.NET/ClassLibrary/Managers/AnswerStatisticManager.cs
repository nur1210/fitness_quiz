using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class AnswerStatisticManager : IAnswerStatisticDb
    {
        private readonly IDbAnswersStatistics _repository;
        public AnswerStatisticManager(IDbAnswersStatistics repository)
        {
            _repository = repository;
        }
        public void AddAnswerStatistic(int userID, int answerID, int questionID) => _repository.AddAnswerStatistic(userID, answerID, questionID);
    }
}
