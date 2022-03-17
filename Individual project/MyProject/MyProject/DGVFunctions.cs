using MyProject.ManagerServices;
using MyProject.Questions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class DGVFunctions
    {
        private BindingSource bsQ = new BindingSource(); // Questions
        private BindingSource bsA = new BindingSource(); // Answers
        private QuestionManager _qM = new QuestionManager();
        private AnswerManager _aM = new AnswerManager();

        public BindingSource QuestionBS { get => bsQ;}
        public BindingSource AnswerBS { get => bsA; set => bsA = value; } 

        public static DataGridViewLinkColumn Edit()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";

            return Editlink;
        }

        public static DataGridViewLinkColumn Delete()
        {
            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";

            return Deletelink;
        }
        public void DGVQuestionsDataSource()
        {
            DataSet ds = CreateQuestionSchema();
            DataTable questions = ds.Tables["Question"];
            DataTable answers = ds.Tables["Answer"];
            bsQ.DataSource = ds;
            bsA.DataSource = ds;
            bsQ.DataMember = questions.TableName;
            bsA.DataMember = answers.TableName;

            List<DataRow> rows = new List<DataRow>();
            for (int i = 0; i < _qM.GetAllQuestions().Count; i++)
            {
                rows.Add(questions.Rows.Add(_qM.GetAllQuestions()[i].ID, _qM.GetAllQuestions()[i].Description));
            }
            foreach (var question in _qM.GetAllQuestions())
            {
                for (int i = 0; i < _aM.GetGetAllAnswersForQuestion(question).Count; i++)
                {
                    answers.Rows.Add(null, question.ID, _aM.GetGetAllAnswersForQuestion(question)[i].Description);
                }
            }
        }
        public static DataSet CreateQuestionSchema()
        {
            DataSet ds = new DataSet();

            DataTable questions = ds.Tables.Add("Question");
            DataColumn q_id = questions.Columns.Add("ID", typeof(int));
            questions.Columns.Add("Description", typeof(string));

            DataTable answers = ds.Tables.Add("Answer");
            DataColumn a_id = answers.Columns.Add("ID", typeof(int));
            answers.Columns.Add("QuestionID", typeof(int));
            answers.Columns.Add("Description", typeof(string));

            DataRelation relation = ds.Relations.Add("Question_Answer",
                questions.Columns["ID"],
                answers.Columns["QuestionID"], true);

            return ds;
        }
    }
}
