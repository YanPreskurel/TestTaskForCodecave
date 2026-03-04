using Microsoft.EntityFrameworkCore;
using SportsCalendar.Data;
using SportsCalendar.Data.Entities;

namespace SportsCalendar.Services;

public class ExerciseService
{
    private readonly AppDbContext _db;

    public ExerciseService(AppDbContext db)
    {
        _db = db;
    }

    // Получаем все типы упражнений
    public async Task<List<ExerciseType>> GetExerciseTypesAsync()
    {
        return await _db.ExerciseTypes.ToListAsync();
    }

    // Получаем упражнения за конкретный день
    public async Task<List<Exercise>> GetExercisesAsync(DateOnly date)
    {
        return await _db.Exercises
            .Include(e => e.ExerciseType)
            .Where(e => e.Date == date)
            .ToListAsync();
    }

    // Добавляем новое упражнение
    public async Task AddExerciseAsync(Exercise exercise)
    {
        _db.Exercises.Add(exercise);
        await _db.SaveChangesAsync();
    }

    // Обновляем существующее упражнение
    public async Task UpdateExerciseAsync(Exercise exercise)
    {
        _db.Exercises.Update(exercise);
        await _db.SaveChangesAsync();
    }

    // Удаляем упражнение по Id
    public async Task DeleteExerciseAsync(Guid id)
    {
        var exercise = await _db.Exercises.FindAsync(id);
        if (exercise != null)
        {
            _db.Exercises.Remove(exercise);
            await _db.SaveChangesAsync();
        }
    }

    public async Task<List<Exercise>> GetExercisesByDateAsync(DateOnly date) =>
    await _db.Exercises
             .Include(e => e.ExerciseType)
             .Where(e => e.Date == date)
             .ToListAsync();
}