namespace Logic.Models;

public interface IScore
{
    int QuestionOptionID { get; set; }
    int ProgramID { get; set; }
    int Weight { get; set; }
}