using ClassLibrary.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class AnswerStatisticManager
    {
        public void AddAnswerStatistic(int answerID, int questionID) => DbAnswersStatistics.AddAnswerStatistic(answerID, questionID);
    }
}
