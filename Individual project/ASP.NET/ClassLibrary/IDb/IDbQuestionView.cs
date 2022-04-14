using Logic.View;

namespace Logic.IDb;

public interface IDbQuestionView
{
    List<QuestionView> GetAllQuestionsForView();
}