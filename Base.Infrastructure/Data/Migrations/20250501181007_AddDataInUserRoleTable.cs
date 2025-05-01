using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInUserRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "10eb7637-95f4-45d2-b200-84dbb188ec41" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "52511e3a-0690-45b0-9e52-02667a473b18" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "52511e3a-0690-45b0-9e52-02667a473c23" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "a0e2f1e7-53e5-416f-b0b0-ca4668563233" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n" },
                    { "0191d311-2918-7f76-bd8a-0bdf740adff9", "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "10eb7637-95f4-45d2-b200-84dbb188ec41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "52511e3a-0690-45b0-9e52-02667a473b18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "52511e3a-0690-45b0-9e52-02667a473c23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "a0e2f1e7-53e5-416f-b0b0-ca4668563233" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0191d311-2918-7f76-bd8a-0bdf740adff9", "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o" });
        }
    }
}
