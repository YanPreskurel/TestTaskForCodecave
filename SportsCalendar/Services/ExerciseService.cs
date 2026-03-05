using Microsoft.EntityFrameworkCore;
using SportsCalendar.Data;
using SportsCalendar.Data.Entities;

namespace SportsCalendar.Services;

public class ExerciseService
{
    private readonly IDbContextFactory<AppDbContext> _factory;

    public ExerciseService(IDbContextFactory<AppDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<ExerciseType>> GetExerciseTypesAsync()
    {
        using var db = await _factory.CreateDbContextAsync();
        return await db.ExerciseTypes.ToListAsync();
    }

    public async Task<List<Exercise>> GetExercisesAsync(DateOnly date)
    {
        using var db = await _factory.CreateDbContextAsync();

        return await db.Exercises
            .Include(e => e.ExerciseType)
            .Where(e => e.Date == date)
            .ToListAsync();
    }

    public async Task AddExerciseAsync(Exercise exercise)
    {
        using var db = await _factory.CreateDbContextAsync();

        db.Exercises.Add(exercise);
        await db.SaveChangesAsync();
    }

    public async Task UpdateExerciseAsync(Exercise exercise)
    {
        using var db = await _factory.CreateDbContextAsync();

        db.Exercises.Update(exercise);
        await db.SaveChangesAsync();
    }

    public async Task DeleteExerciseAsync(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();

        var exercise = await db.Exercises.FindAsync(id);

        if (exercise != null)
        {
            db.Exercises.Remove(exercise);
            await db.SaveChangesAsync();
        }
    }

    public async Task<List<Exercise>> GetExercisesByDateAsync(DateOnly date)
    {
        using var db = await _factory.CreateDbContextAsync();

        return await db.Exercises
            .Include(e => e.ExerciseType)
            .Where(e => e.Date == date)
            .ToListAsync();
    }
}