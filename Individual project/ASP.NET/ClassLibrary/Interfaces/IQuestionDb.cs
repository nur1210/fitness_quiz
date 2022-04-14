using Logic.Models;

namespace Logic.Interfaces;

public interface IQuestionDb
{
    public void AddQuestion(Question q);
    public void EditQuestion(int questionID, string descpription);
    public void RemoveQuestion(int questionID);
    public List<Question> GetAllQuestions();
    public int GetNextQuestionID();
    public int GetInsertedQuestionID();
    public Question GetQuestionByID(int questionID);
}