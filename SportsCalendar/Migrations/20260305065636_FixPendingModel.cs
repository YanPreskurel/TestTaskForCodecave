using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsCalendar.Migrations
{
    /// <inheritdoc />
    public partial class FixPendingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "Name",
                value: "Ходьба");

            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "Name", "Unit" },
                values: new object[] { "Велосипед", "км" });

            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "Name", "Unit" },
                values: new object[] { "Планка", "мин" });

            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "Name",
                value: "Отжимания");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "Name",
                value: "Велосипед");

            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "Name", "Unit" },
                values: new object[] { "Плавание", "мин" });

            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "Name", "Unit" },
                values: new object[] { "Отжимания", "раз" });

            migrationBuilder.UpdateData(
                table: "ExerciseTypes",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "Name",
                value: "Пресс");
        }
    }
}
