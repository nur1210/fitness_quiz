using Logic.View;

namespace Logic.Managers;

public interface IQuestionViewDb
{
    public List<QuestionView> GetAllQuestionsForView();
}