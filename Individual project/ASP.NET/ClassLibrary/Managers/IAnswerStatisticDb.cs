namespace Logic.Managers;

public interface IAnswerStatisticDb
{
    public void AddAnswerStatistic(int userID, int answerID, int questionID);
}