namespace SportsCalendar.Data.Entities;

public class Exercise
{
    public Guid Id { get; set; }

    public DateOnly Date { get; set; }

    public Guid ExerciseTypeId { get; set; }

    public ExerciseType ExerciseType { get; set; } = null!;

    public decimal Value { get; set; }

    public bool IsCompleted { get; set; }
}