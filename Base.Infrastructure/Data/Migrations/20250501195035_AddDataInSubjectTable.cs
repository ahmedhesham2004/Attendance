using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInSubjectTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "DepartmentId", "DoctorId", "LevelId", "Name", "Samester" },
                values: new object[,]
                {
                    { 1, "1", 1, 1, 1, "مبادئ اقتصاد 1", 1 },
                    { 2, "2", 1, 2, 1, "حزم تطبيقات مكتبيه", 1 },
                    { 3, "3", 1, 3, 1, "مبادئ محاسبه 1", 1 },
                    { 4, "4", 1, 4, 1, "لغة إنجليزية 1", 1 },
                    { 5, "5", 1, 5, 1, "مقدمه في الحاسب", 1 },
                    { 6, "6", 1, 6, 1, "مبادئ الاداره", 1 },
                    { 7, "7", 1, 7, 1, "مبادئ البرمجة للأعمال", 2 },
                    { 8, "8", 1, 8, 1, "اقتصاد 2", 2 },
                    { 9, "9", 1, 9, 1, "السلوك التنظيمي", 2 },
                    { 10, "10", 1, 10, 1, "مبادئ محاسبه 2", 2 },
                    { 11, "11", 1, 11, 1, "مبادئ احصاء", 2 },
                    { 12, "12", 1, 12, 1, "أساسيات نظم المعلومات", 2 },
                    { 13, "13", 2, 13, 1, "أساسيات تكنولوجيا المعلومات", 1 },
                    { 14, "14", 2, 14, 1, "مقدمه في البرمجه", 1 },
                    { 15, "15", 2, 15, 1, "حزم تطبيقات مكتبيه", 1 },
                    { 16, "16", 2, 1, 1, "مقدمة في الحاسبات", 1 },
                    { 17, "17", 2, 2, 1, "الرياضيات المنفصلة", 1 },
                    { 18, "18", 2, 3, 1, "تفاضل وتكامل", 2 },
                    { 19, "19", 2, 4, 1, "رياضيات الحاسب", 2 },
                    { 20, "20", 2, 5, 1, "أسس التفكير النقدي والعلمي", 2 },
                    { 21, "21", 2, 6, 1, "برمجه الحاسب 1", 2 },
                    { 22, "22", 2, 7, 1, "احتمالات وإحصاء", 2 },
                    { 23, "23", 1, 8, 2, "نظم التشغيل", 1 },
                    { 24, "24", 1, 9, 2, "مبادئ التسويق", 1 },
                    { 25, "25", 1, 10, 2, "علم الجوده", 1 },
                    { 26, "26", 1, 11, 2, "محاسبة متوسطة", 1 },
                    { 27, "27", 1, 12, 2, "نقود وبنوك", 1 },
                    { 28, "28", 1, 13, 2, "إحصاء تطبيقي", 1 },
                    { 29, "29", 1, 14, 2, "تطبيقات الانترنت", 2 },
                    { 30, "30", 1, 15, 2, "التجاره الالكترونيه", 2 },
                    { 31, "31", 1, 1, 2, "لغات البرمجه للأعمال 1", 2 },
                    { 32, "32", 1, 2, 2, "نظم معلومات الأعمال", 2 },
                    { 33, "33", 1, 3, 2, "محاسبه متوسطه 2", 2 },
                    { 34, "34", 2, 4, 2, "نظم التشغيل", 1 },
                    { 35, "35", 2, 5, 2, "مبادئ التسويق", 1 },
                    { 36, "36", 2, 6, 2, "محاسبة متوسطة", 1 },
                    { 37, "37", 2, 7, 2, "شبكات الحاسب 1", 1 },
                    { 38, "38", 2, 8, 2, "مقدمة في علم البيانات", 1 },
                    { 39, "39", 2, 9, 2, "تطبيقات الانترنت", 2 },
                    { 40, "40", 2, 10, 2, "تطبيقات في الأمن السيبراني", 2 },
                    { 41, "41", 2, 11, 2, "تكنولوجيا الوسائط المتعدده ", 2 },
                    { 42, "42", 2, 12, 2, "نظم معلومات الأعمال", 2 },
                    { 43, "43", 2, 13, 2, "تطبيقات الخوارزميات", 2 },
                    { 44, "44", 2, 14, 2, "برمجه الحاسب 2", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44);
        }
    }
}
