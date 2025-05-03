using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCodeForStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Code",
                value: "C3345325");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Code",
                value: "7");
        }
    }
}
