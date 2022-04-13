namespace Logic.Models;

public interface IAnswer
{
    int ID { get; set; }
    int QuestionId { get; set; }
    string Description { get; set; }
    int ProgramID { get; set; }
}