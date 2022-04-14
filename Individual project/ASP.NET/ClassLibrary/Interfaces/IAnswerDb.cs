using Logic.Models;

namespace Logic.Interfaces;

public interface IAnswerDb
{
    void AddAnswer(Answer a); 
    void RemoveAnswer(Answer a);
    void EditAnswer(Answer a);
    List<Answer> GetAllAnswers();
    List<Answer> GetGetAllAnswersForQuestion(Question q);
    void AddProgramReference(int answerID, int programID);
    void RemoveProgramReference(int answerID);
    bool HasProgramReference(int answerID);
    int GetProgramReference(int answerID);
    Answer GetAnswerByID(int answerID);

}