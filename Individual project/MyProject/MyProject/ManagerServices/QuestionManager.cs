using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Questions
{
    public class QuestionManager
    {

        public void AddQuestion(Question q) => DbQuestions.AddQuestion(q);
        public void EditQuestion(Question q) => DbQuestions.UpdateQuestion(q);
        public void RemoveQuestion(Question q) => DbQuestions.DeleteQuestion(q);
        public List<Question> GetAllQuestions() => DbQuestions.GetAllQuestions();
        public int GetNextQuestionID() => DbQuestions.GetNextQuestionID();
        public int GetInsertedQuestionID() => DbQuestions.GetInsertedQuestionID();

    }
}
