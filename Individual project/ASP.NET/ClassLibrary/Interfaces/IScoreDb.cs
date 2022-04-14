using Logic.Models;

namespace Logic.Interfaces;

public interface IScoreDb
{
    public void AddScore(Score s);
    public void UpdateScore(Score score);
    public void DeleteScore(Score score);
}