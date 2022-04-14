using Logic.Models;

namespace Logic.IDb;

public interface IDbAnswers
{
    void AddAnswer(Answer answer);
    void EditAnswer(Answer answer);
    void RemoveAnswer(Answer answer);
    List<Answer> GetAllAnswers();
    List<Answer> GetGetAllAnswersForQuestion(Question question);
    Answer GetAnswerByID(int answerID);

}