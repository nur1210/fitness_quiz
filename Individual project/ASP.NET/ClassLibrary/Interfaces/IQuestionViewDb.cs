using Logic.View;

namespace Logic.Interfaces;

public interface IQuestionViewDb
{
    public List<QuestionView> GetAllQuestionsForView();
}