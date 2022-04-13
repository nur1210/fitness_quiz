using Logic.Models;

namespace Logic.Interfaces;

public interface IDbQuestions
{
    void AddQuestion(Question q);
    void EditQuestion(int questionID, string descpription);
    void RemoveQuestion(int questionID);
    List<Question> GetAllQuestions();
    int GetNextQuestionID();
    int GetInsertedQuestionID();
    Question GetQuestionByID(int questionID);
}