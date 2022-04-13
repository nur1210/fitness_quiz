using Logic.View;

namespace Logic.Interfaces;

public interface IDbQuestionView
{
    List<QuestionView> GetAllQuestionsForView();
}