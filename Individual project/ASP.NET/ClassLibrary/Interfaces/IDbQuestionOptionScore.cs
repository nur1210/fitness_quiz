using Logic.Models;

namespace Logic.Interfaces;

public interface IDbQuestionOptionScore
{
    void AddScore(Score s);
    void UpdateScore(Score s);
    void DeleteScore(Score s);
}