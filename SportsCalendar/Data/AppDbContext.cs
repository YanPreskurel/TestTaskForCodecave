using Microsoft.EntityFrameworkCore;
using SportsCalendar.Data.Entities;

namespace SportsCalendar.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<ExerciseType> ExerciseTypes => Set<ExerciseType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ExerciseType>().HasData(
            new ExerciseType
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Бег",
                Unit = "км"
            },
            new ExerciseType
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Велосипед",
                Unit = "км"
            },
            new ExerciseType
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Плавание",
                Unit = "мин"
            },
            new ExerciseType
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Name = "Отжимания",
                Unit = "раз"
            },
            new ExerciseType
            {
                Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                Name = "Пресс",
                Unit = "раз"
            }
        );
    }
}