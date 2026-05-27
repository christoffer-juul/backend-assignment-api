using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Hours", "IconUrl", "Level", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 12, "/images/assignments/design-icon.png", "Advanced", "Design Accessibility", "in-progress" },
                    { 2, 16, "/images/assignments/figma-logo.png", "Intermediate", "Figma for Beginner", "in-progress" },
                    { 3, 22, "/images/assignments/framer-logo.png", "Advanced", "Framer Design", "completed" },
                    { 4, 14, "/images/assignments/appstore-icon.png", "Intermediate", "Frontend Development", "in-progress" },
                    { 5, 18, "/images/assignments/behance-logo.png", "Intermediate", "Behance Case Study", "in-progress" },
                    { 6, 10, "/images/assignments/design-icon.png", "Beginner", "UI Design Fundamentals", "in-progress" },
                    { 7, 20, "/images/assignments/appstore-icon.png", "Beginner", "React for Beginners", "in-progress" },
                    { 8, 14, "/images/assignments/appstore-icon.png", "Intermediate", "TypeScript Essentials", "completed" },
                    { 9, 18, "/images/assignments/design-icon.png", "Advanced", "UX Research Methods", "in-progress" },
                    { 10, 24, "/images/assignments/design-icon.png", "Intermediate", "Motion Design with After Effects", "completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");
        }
    }
}
