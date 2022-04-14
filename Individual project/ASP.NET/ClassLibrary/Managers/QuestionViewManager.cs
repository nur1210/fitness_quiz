using Logic.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class QuestionViewManager : IQuestionViewDb
    {
        private readonly IDbQuestionView _repository;

        public QuestionViewManager()
        {
        }
        public QuestionViewManager(IDbQuestionView repository)
        {
            _repository = repository;
        }
        public List<QuestionView> GetAllQuestionsForView() => _repository.GetAllQuestionsForView();
    }
}
