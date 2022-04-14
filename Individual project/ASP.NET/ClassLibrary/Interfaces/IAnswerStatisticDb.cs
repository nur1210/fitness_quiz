namespace Logic.Interfaces;

public interface IAnswerStatisticDb
{
    public void AddAnswerStatistic(int userID, int answerID, int questionID);
}