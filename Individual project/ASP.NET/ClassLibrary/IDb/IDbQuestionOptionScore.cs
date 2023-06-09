﻿using Logic.Models;

namespace Logic.IDb;

public interface IDbQuestionOptionScore
{
    void AddScore(Score s);
    void UpdateScore(Score s);
    void DeleteScore(Score s);
    List<Score> GetAllScores();
    Score GetScore(int programID, int questionOptionID);
    List<Answer> GetAllAnswersWithoutScore();
    bool HasScore(int answerID, int programID);
}