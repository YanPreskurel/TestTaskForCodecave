namespace SportsCalendar.Data.Entities;

public class ExerciseType
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Unit { get; set; } = string.Empty;
}