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
    }
}
