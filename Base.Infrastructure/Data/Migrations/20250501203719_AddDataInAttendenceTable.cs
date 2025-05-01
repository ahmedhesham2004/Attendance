using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInAttendenceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendences",
                table: "Attendences");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Attendences",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendences",
                table: "Attendences",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendences_StudentId",
                table: "Attendences",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendences",
                table: "Attendences");

            migrationBuilder.DropIndex(
                name: "IX_Attendences_StudentId",
                table: "Attendences");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Attendences");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendences",
                table: "Attendences",
                columns: new[] { "StudentId", "SubjectId" });
        }
    }
}
