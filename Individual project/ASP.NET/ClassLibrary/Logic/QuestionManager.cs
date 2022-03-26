using ClassLibrary.DB;
using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class QuestionManager
    {

        public void AddQuestion(Question q) => DbQuestions.AddQuestion(q);
        public void EditQuestion(int questionID, string descpription) => DbQuestions.UpdateQuestion(questionID, descpription);
        public void RemoveQuestion(int questionID) => DbQuestions.DeleteQuestion(questionID);
        public List<Question> GetAllQuestions() => DbQuestions.GetAllQuestions();
        public int GetNextQuestionID() => DbQuestions.GetNextQuestionID();
        public int GetInsertedQuestionID() => DbQuestions.GetInsertedQuestionID();
        public Question GetQuestionByID(int questionID) => DbQuestions.GetQuestionByID(questionID);

    }
}
