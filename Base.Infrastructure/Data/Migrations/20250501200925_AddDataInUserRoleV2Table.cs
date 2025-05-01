using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInUserRoleV2Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "249aa6c5-d578-4517-8a42-48f24a7d959e" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "49a438ba-672d-41d5-97ba-5536ffbec2a6" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "5d577849-97d1-4984-bf96-6fee7d08c8be" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "683211b1-1125-42a1-b148-a606a4ca4df3" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "6b9b3e85-ce32-4944-9a46-601bb2b40000" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "8766c317-1eaa-468a-b34d-59790c8eb915" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "bf2ee728-59af-45ec-9b70-e5f5e27eef8e" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "cb3cb7ca-1921-49fd-a11e-600b351b3df2" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "cb3cb7ca-1921-49fd-a11e-600b351b3df3" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "cb3cb7ca-1921-49fd-a11e-600b351b3df4" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "ce47a5ab-df14-416a-b500-9b544fa666a4" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "df2ea217-2e82-48b9-9442-47556c1a9403" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "f89bca4a-8fc9-4259-a46d-22562907c27f" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "fc4df06f-05c2-4751-96c1-8040f2761b7f" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "249aa6c5-d578-4517-8a42-48f24a7d959e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "49a438ba-672d-41d5-97ba-5536ffbec2a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "5d577849-97d1-4984-bf96-6fee7d08c8be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "683211b1-1125-42a1-b148-a606a4ca4df3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "6b9b3e85-ce32-4944-9a46-601bb2b40000" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "8766c317-1eaa-468a-b34d-59790c8eb915" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "bf2ee728-59af-45ec-9b70-e5f5e27eef8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "cb3cb7ca-1921-49fd-a11e-600b351b3df2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "cb3cb7ca-1921-49fd-a11e-600b351b3df3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "cb3cb7ca-1921-49fd-a11e-600b351b3df4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "ce47a5ab-df14-416a-b500-9b544fa666a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "df2ea217-2e82-48b9-9442-47556c1a9403" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "f89bca4a-8fc9-4259-a46d-22562907c27f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "fc4df06f-05c2-4751-96c1-8040f2761b7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adfA9", "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i" });
        }
    }
}
