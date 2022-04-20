using Logic.Models;

namespace Logic.IDb;

public interface IDbAnswersStatistics
{
    List<Answer> GetAllAnswersAnsweredByAllUsers();
}