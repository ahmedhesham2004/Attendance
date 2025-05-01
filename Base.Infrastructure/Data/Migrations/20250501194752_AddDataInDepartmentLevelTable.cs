using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInDepartmentLevelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartmentLevel",
                columns: new[] { "DepartmentId", "LevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentLevel",
                keyColumns: new[] { "DepartmentId", "LevelId" },
                keyValues: new object[] { 5, 4 });
        }
    }
}
