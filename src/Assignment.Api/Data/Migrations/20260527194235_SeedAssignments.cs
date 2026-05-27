using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedAssignments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Hours", "Level", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 12, "Advanced", "Design Accessibility", "in-progress" },
                    { 2, 16, "Intermediate", "Figma for Beginner", "in-progress" },
                    { 3, 22, "Advanced", "Framer Design", "completed" },
                    { 4, 14, "Intermediate", "Frontend Development", "in-progress" },
                    { 5, 18, "Intermediate", "Behance Case Study", "in-progress" },
                    { 6, 10, "Beginner", "UI Design Fundamentals", "in-progress" },
                    { 7, 20, "Beginner", "React for Beginners", "in-progress" },
                    { 8, 14, "Intermediate", "TypeScript Essentials", "completed" },
                    { 9, 18, "Advanced", "UX Research Methods", "in-progress" },
                    { 10, 24, "Intermediate", "Motion Design with After Effects", "completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
