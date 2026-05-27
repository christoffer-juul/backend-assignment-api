using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIconUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Assignments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconUrl",
                value: "/images/assignments/design-icon.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconUrl",
                value: "/images/assignments/figma-logo.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconUrl",
                value: "/images/assignments/framer-logo.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                column: "IconUrl",
                value: "/images/assignments/appstore-icon.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                column: "IconUrl",
                value: "/images/assignments/behance-logo.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                column: "IconUrl",
                value: "/images/assignments/design-icon.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                column: "IconUrl",
                value: "/images/assignments/appstore-icon.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                column: "IconUrl",
                value: "/images/assignments/appstore-icon.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                column: "IconUrl",
                value: "/images/assignments/design-icon.png");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                column: "IconUrl",
                value: "/images/assignments/design-icon.png");
        }
    }
}
