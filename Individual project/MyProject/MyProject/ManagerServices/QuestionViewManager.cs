using MyProject.DB;
using MyProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ManagerServices
{
    public class QuestionViewManager
    {
        public List<QuestionView> GetAllQuestionsForView() => DbQuestionView.GetAllQuestionsForView();
    }
}
