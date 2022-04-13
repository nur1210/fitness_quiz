using Logic.Models;

namespace Logic.Managers;

public interface IAnswerDb
{
    public void AddAnswer(Answer a);
    public void RemoveAnswer(Answer a);
    public void EditAnswer(Answer a);
    public List<Answer> GetAllAnswers();
    public List<Answer> GetGetAllAnswersForQuestion(Question q);
    public void AddProgramReference(int answerID, int programID);
    public void RemoveProgramReference(int answerID);
    public bool HasProgramReference(int answerID);
    public int GetProgramReference(int answerID);
}