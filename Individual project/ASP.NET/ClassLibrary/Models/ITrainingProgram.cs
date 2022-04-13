namespace Logic.Models;

public interface ITrainingProgram
{
    int ID { get; set; }
    string Description { get; set; }
    int TypeID { get; set; }
    int RestBetweenSets { get; set; }
    IEnumerable<int> RepRange { get; set; }
    IEnumerable<int> AgeRange { get; set; }
    TrainingProgram ToBeActiveProgram();
    TrainingProgram ToBeStrengthProgram();
    TrainingProgram ToBeWeightLossProgram();
    TrainingProgram ToBeMuscleGainProgram();
    string GetName();
}