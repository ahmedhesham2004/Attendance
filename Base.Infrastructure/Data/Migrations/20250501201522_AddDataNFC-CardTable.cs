using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataNFCCardTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NFC_Cards",
                columns: new[] { "Id", "Code", "ImageUrl", "StudentId" },
                values: new object[,]
                {
                    { 1, "1", "CardImages/1.jpg", 1 },
                    { 2, "2", "CardImages/2.jpg", 2 },
                    { 3, "3", "CardImages/3.jpg", 3 },
                    { 4, "4", "CardImages/4.jpg", 4 },
                    { 5, "5", "CardImages/5.jpg", 5 },
                    { 6, "6", "CardImages/6.jpg", 6 },
                    { 7, "7", "CardImages/7.jpg", 7 },
                    { 8, "8", "CardImages/8.jpg", 8 },
                    { 9, "9", "CardImages/9.jpg", 9 },
                    { 10, "10", "CardImages/10.jpg", 10 },
                    { 11, "11", "CardImages/11.jpg", 11 },
                    { 12, "12", "CardImages/12.jpg", 12 },
                    { 13, "13", "CardImages/13.jpg", 13 },
                    { 14, "14", "CardImages/14.jpg", 14 },
                    { 15, "15", "CardImages/15.jpg", 15 },
                    { 16, "16", "CardImages/16.jpg", 16 },
                    { 17, "17", "CardImages/17.jpg", 17 },
                    { 18, "18", "CardImages/18.jpg", 18 },
                    { 19, "19", "CardImages/19.jpg", 19 },
                    { 20, "20", "CardImages/20.jpg", 20 },
                    { 21, "21", "CardImages/21.jpg", 21 },
                    { 22, "22", "CardImages/22.jpg", 22 },
                    { 23, "23", "CardImages/23.jpg", 23 },
                    { 24, "24", "CardImages/24.jpg", 24 },
                    { 25, "25", "CardImages/25.jpg", 25 },
                    { 26, "26", "CardImages/26.jpg", 26 },
                    { 27, "27", "CardImages/27.jpg", 27 },
                    { 28, "28", "CardImages/28.jpg", 28 },
                    { 29, "29", "CardImages/29.jpg", 29 },
                    { 30, "30", "CardImages/30.jpg", 30 },
                    { 31, "31", "CardImages/31.jpg", 31 },
                    { 32, "32", "CardImages/32.jpg", 32 },
                    { 33, "33", "CardImages/33.jpg", 33 },
                    { 34, "34", "CardImages/34.jpg", 34 },
                    { 35, "35", "CardImages/35.jpg", 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NFC_Cards",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
