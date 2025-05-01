using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "0191d311-2918-7f76-bd8a-0bdf740adfA9", "Student", "STUDENT" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "0191d311-2918-7f76-bd8a-0bdf740adff9", "Doctor", "DOCTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0191d311-2918-7f76-bd8a-0bdf740adfA9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0191d311-2918-7f76-bd8a-0bdf740adff9");
        }
    }
}
