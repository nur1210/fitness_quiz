using ClassLibrary.DB;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class AnswerManager
    {
        public void AddAnswer(Answer a) => DbAnswers.AddAnswer(a);
        public void RemoveAnswer(Answer a) => DbAnswers.DeleteAnswer(a);
        public void EditAnswer(Answer a) => DbAnswers.UpdateAnswer(a);
        public List<Answer> GetAllAnswers() => DbAnswers.GetAllAnsers();
        public List<Answer> GetGetAllAnswersForQuestion(Question q) => DbAnswers.GetAllAnswersForQuestion(q);
    }
}
