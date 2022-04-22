using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class AnswerStatisticManager
    {
        private readonly IDbAnswersStatistics _repository;
        public AnswerStatisticManager(IDbAnswersStatistics repository)
        {
            _repository = repository;
        }

        public int SumOfFemaleUsers() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 2).ToList().Count;
        public int SumOfMaleUsers() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 1).ToList().Count;
        public int SumOfUsersUnderTwenty() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 3).ToList().Count;
        public int SumOfUsersBetweenTwentyToThirty() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 4).ToList().Count;
        public int SumOfUsersBetweenThirtyToForty() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 5).ToList().Count;
        public int SumOfUsersBetweenFortyToFifty() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 6).ToList().Count;
        public int SumOfUsersBetweenFiftyToSixty() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 7).ToList().Count;
        public int SumOfUsersAboveSixty() => _repository.GetAllAnswersAnsweredByAllUsers().Where(x => x.ID == 8).ToList().Count;
    }
}
