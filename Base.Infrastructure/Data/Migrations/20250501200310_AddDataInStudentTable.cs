using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ApplicationUserId", "DepartmentId", "LevelId" },
                values: new object[,]
                {
                    { 1, "683211b1-1125-42a1-b148-a606a4ca4df3", 1, 1 },
                    { 2, "df2ea217-2e82-48b9-9442-47556c1a9403", 1, 1 },
                    { 3, "6b9b3e85-ce32-4944-9a46-601bb2b40000", 1, 1 },
                    { 4, "fc4df06f-05c2-4751-96c1-8040f2761b7f", 1, 1 },
                    { 5, "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4", 1, 1 },
                    { 6, "ce47a5ab-df14-416a-b500-9b544fa666a4", 1, 1 },
                    { 7, "249aa6c5-d578-4517-8a42-48f24a7d959e", 1, 1 },
                    { 8, "49a438ba-672d-41d5-97ba-5536ffbec2a6", 1, 1 },
                    { 9, "bf2ee728-59af-45ec-9b70-e5f5e27eef8e", 1, 1 },
                    { 10, "cb3cb7ca-1921-49fd-a11e-600b351b3df2", 1, 1 },
                    { 11, "cb3cb7ca-1921-49fd-a11e-600b351b3df3", 2, 1 },
                    { 12, "5d577849-97d1-4984-bf96-6fee7d08c8be", 2, 1 },
                    { 13, "f89bca4a-8fc9-4259-a46d-22562907c27f", 2, 1 },
                    { 14, "cb3cb7ca-1921-49fd-a11e-600b351b3df4", 2, 1 },
                    { 15, "8766c317-1eaa-468a-b34d-59790c8eb915", 2, 1 },
                    { 16, "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p", 2, 1 },
                    { 17, "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q", 2, 1 },
                    { 18, "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r", 2, 1 },
                    { 19, "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s", 2, 1 },
                    { 20, "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t", 2, 1 },
                    { 21, "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u", 1, 2 },
                    { 22, "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v", 1, 2 },
                    { 23, "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w", 1, 2 },
                    { 24, "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x", 1, 2 },
                    { 25, "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y", 1, 2 },
                    { 26, "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z", 1, 2 },
                    { 27, "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a", 1, 2 },
                    { 28, "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b", 2, 2 },
                    { 29, "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c", 2, 2 },
                    { 30, "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d", 2, 2 },
                    { 31, "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e", 2, 2 },
                    { 32, "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f", 2, 2 },
                    { 33, "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g", 2, 2 },
                    { 34, "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h", 2, 2 },
                    { 35, "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i", 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
