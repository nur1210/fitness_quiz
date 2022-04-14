namespace Logic.IDb;

public interface IDbAnswersStatistics
{
    void AddAnswerStatistic(int userID, int answerID, int questionID);
}