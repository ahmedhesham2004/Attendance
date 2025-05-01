using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInDoctorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ApplicationUserId" },
                values: new object[,]
                {
                    { 1, "10eb7637-95f4-45d2-b200-84dbb188ec41" },
                    { 2, "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1" },
                    { 3, "a0e2f1e7-53e5-416f-b0b0-ca4668563233" },
                    { 4, "52511e3a-0690-45b0-9e52-02667a473b18" },
                    { 5, "52511e3a-0690-45b0-9e52-02667a473c23" },
                    { 6, "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j" },
                    { 7, "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k" },
                    { 8, "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l" },
                    { 9, "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m" },
                    { 10, "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n" },
                    { 11, "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o" },
                    { 12, "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p" },
                    { 13, "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q" },
                    { 14, "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r" },
                    { 15, "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
