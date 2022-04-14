using Logic.Models;

namespace Logic.IDb;

public interface IDbAnswers
{
    void AddAnswer(Answer answer);
    void EditAnswer(Answer answer);
    void RemoveAnswer(Answer answer);
    List<Answer> GetAllAnswers();
    List<Answer> GetGetAllAnswersForQuestion(Question question);
    void AddProgramReference(int answerID, int programID);
    void RemoveProgramReference(int answerID);
    bool HasProgramReference(int answerID);
    int GetProgramReference(int answerID);
    Answer GetAnswerByID(int answerID);

}