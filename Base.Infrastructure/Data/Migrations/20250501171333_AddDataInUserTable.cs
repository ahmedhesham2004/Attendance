using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Base.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NationalId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10eb7637-95f4-45d2-b200-84dbb188ec41", 0, "1ca42846-c687-48a2-9eb4-77fc5f21ae44", "Ramy2@gmail.com", true, "رامي", "profiles/16 Black Chefs Changing Food in America (Published 2019).jpeg", "عزيز", false, null, "30303409168364", "RAMY2@GMAIL.COM", "RAMY2@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "011298640281", false, "f439954d-63d4-4e36-8a5f-827f533cc6a1", "Male", false, "Ramy2@gmail.com" },
                    { "249aa6c5-d578-4517-8a42-48f24a7d959e", 0, "e7ed49bc-72fb-42be-afc5-fbd0351bd759", "Khaled2@gmail.com", true, "زياد محمد", "profiles/MEN - Location - Headshot Photography by Brandon Tabiolo.jpeg", "الشحات", false, null, "30301920482846", "KHALED2@GMAIL.COM", "KHALED2@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01293749183", false, "f85433e6-bf5b-4ffc-9d02-3a7cc9938547", "Male", false, "Khaled2@gmail.com" },
                    { "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1", 0, "d607b523-2920-4ea8-83c4-2103dbb45b0a", "Rola@gmail.com", true, "رولا", "profiles/Before and After_ Transforming Your LinkedIn Profile with AI Headshots.jpeg", "سامي", false, null, "30306183028747", "ROLA@GMAIL.COM", "ROLA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "012938475601", false, "eac93f1e-749b-4c66-9783-c46c16b4ffbf", "Female", false, "Rola@gmail.com" },
                    { "49a438ba-672d-41d5-97ba-5536ffbec2a6", 0, "f9773109-8364-4c61-a5d4-9fe85a58c0f4", "Kareem@gmail.com", true, "شهد عصمت فؤاد", "profiles/Why I Mainly Photograph in Portrait Orientation for Actors' Headshots.jpeg", "بكر", false, null, "303092689146845", "KAREEM@GMAIL.COM", "KAREEM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01024860821", false, "aed0822d-8180-49b3-85cc-a4f5a33a3b56", "Female", false, "Kareem@gmail.com" },
                    { "52511e3a-0690-45b0-9e52-02667a473b18", 0, "e184b3aa-6771-4830-83f9-b1a59c9676c4", "Magdy@gmail.com", true, "ماجد", "profiles/Dallas Headshots Photographer - Willie & Kim Photography.jpeg", "عبدالله", false, null, "30301789256730", "MAGDY@GMAIL.COM", "MAGDY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01183670178", false, "fda38b97-da47-40ba-bbe3-702a78f4e009", "Male", false, "Magdy@gmail.com" },
                    { "52511e3a-0690-45b0-9e52-02667a473c23", 0, "e184b3aa-6771-4830-83f9-b1a59c967aB6", "Yousef@gmail.com", true, "يوسف", "profiles/Dallas Headshots Photographer - Willie & Kim Photography.jpeg", "سيد", false, null, "30301599256730", "YOUSEF@GMAIL.COM", "YOUSEF@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01283670178", false, "fda38b97-da47-40ba-bbe3-702a78f4ec15", "Male", false, "Yousef@gmail.com" },
                    { "5d577849-97d1-4984-bf96-6fee7d08c8be", 0, "edb44c87-00c3-488a-9b74-2fc632b48bfc", "Marry@gmail.com", true, "مؤمن رفعت", "profiles/468f9794-778b-429f-bea8-b7440810819d.jpeg", "كمال", false, null, "40423109753269", "MARRY@GMAIL.COM", "MARRY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "02029837399", false, "e27dc6f7-4bf0-44a1-a3fb-8b3e5239e87f", "Male", false, "Marry@gmail.com" },
                    { "683211b1-1125-42a1-b148-a606a4ca4df3", 0, "b3c8f4ef-c9ab-49b5-9b16-06f17aa7668a", "Ahmed12@gmail.com", true, "احمد مصطفي", "profiles/df4fb389-64ed-486e-be7d-722771b6e3bc.jpeg", "محمد الامير", false, null, "30305521354688", "AHMED12@GMAIL.COM", "AHMED12@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01024866094", false, "46e17415-53e4-4e26-8ce4-3b9f91a4ebcd", "Male", false, "Ahmed12@gmail.com" },
                    { "6b9b3e85-ce32-4944-9a46-601bb2b40000", 0, "a61c81ae-cdb2-4c92-ae17-75247a4cb5cb", "Hassan44@gmail.com", true, "اية محمد", "profiles/Friendly Professional Business Headshot.jpeg", "علي محمد", false, null, "30306729061246", "HASSAN4412@GMAIL.COM", "HASSAN4412@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01079945073", false, "33fe0c4e-09d7-4b8b-a625-7cf0651fb90e", "Female", false, "Hassan44@gmail.com" },
                    { "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4", 0, "0a0bc059-4d5d-45dc-98dc-5e557d7aa1c1", "Maher@gmail.com", true, "سارة ثروت", "profiles/Rajan Velu.jpeg", "موسي", false, null, "30301937508274", "MAHER@GMAIL.COM", "MAHER@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01208173649", false, "04a9f78c-43b0-4a6f-bb40-c161adb30b23", "Female", false, "Maher@gmail.com" },
                    { "8766c317-1eaa-468a-b34d-59790c8eb915", 0, "c4986d9a-0ff6-4ecb-9f51-b8bb5dc826e4", "Rana2@gmail.com", true, "ندي نسيم", "profiles/2edc3141-b4cd-411d-9136-33440bbb1c03.jpeg", "علي احمد", false, null, "30304597102873", "RANA2@GMAIL.COM", "RANA2@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01028649032", false, "f5e74c9d-fe75-442e-a90e-6400f6a2f0c7", "Female", false, "Rana2@gmail.com" },
                    { "a0e2f1e7-53e5-416f-b0b0-ca4668563233", 0, "a46ec364-f74a-455e-93f2-471913135d05", "Malek@gmail.com", true, "مالك", "profiles/9c12d50d-5cbe-4c75-8bca-cbc57d504a7b.jpeg", "محمد", false, null, "30308103829384", "MALEK@GMAIL.COM", "MALEK@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01283604718", false, "16dd3214-5abc-48b6-83cd-df00d21f16dc", "Male", false, "Malek@gmail.com" },
                    { "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p", 0, "d726e933-b5gd-5b4b-9c34-c5c7d166c97h", "Ahmed@gmail.com", true, "أحمد علي", "profiles/55060g50-773e-519c-0eef-0f4382e8d47f.jpg", "عبد الرحمن", false, null, "1234567890123456", "AHMED@GMAIL.COM", "AHMED@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "071234567890", false, "7908371e-7541-5244-979f-9192e12fe67g", "Male", false, "Ahmed@gmail.com" },
                    { "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p", 0, "d28qe5tt-b1g7-1b0b-6c90-c2c4d8p3d64h", "Sama@gmail.com", true, "سما عماد", "profiles/11226g26-445e-17zc-6eef-6f09y8e4d03f.jpeg", "ياسر عبد المنعم", false, null, "7788990011223344", "SAMA@GMAIL.COM", "SAMA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "077788990011", false, "46860q9e-4219-3922-75zf-7951e01ef56g", "Female", false, "Sama@gmail.com" },
                    { "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q", 0, "e837f044-c6he-6c5c-0d45-d6d8e277d08i", "Sara@gmail.com", true, "سارة محمد", "profiles/66071h61-884f-62ad-1ffg-1g5493f9e58g.png", "عبد الله", false, null, "2345678901234567", "SARA@GMAIL.COM", "SARA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "072345678901", false, "8019482f-8652-6355-08ag-0283f23gf78h", "Female", false, "Sara@gmail.com" },
                    { "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q", 0, "e39rf6uu-c2h8-2c1c-7d01-d3d5e9q4e75i", "Amr@gmail.com", true, "عمرو أسامة", "profiles/22337h37-556f-28ad-7ffg-7g10z9f5e14g.jpg", "سعيد عبد القادر", false, null, "8899001122334455", "AMR@GMAIL.COM", "AMR@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "078899001122", false, "57971r0f-5320-4033-86ag-8062f12fg67h", "Male", false, "Amr@gmail.com" },
                    { "bf2ee728-59af-45ec-9b70-e5f5e27eef8e", 0, "43d7bf34-bc3a-4d7f-841e-f1dfd028303d", "Halem@gmail.com", true, "شهد حسن", "profiles/Gorgeous smile of Alexis Petit.jpeg", "عبدااللاه حسن", false, null, "30308391092836", "HALEM@GMAIL.COM", "HALEM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01049182640", false, "999faa1d-9041-4c56-888c-42b8286d68b7", "Female", false, "Halem@gmail.com" },
                    { "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r", 0, "f948g155-d7if-7d6d-1e56-e7e9f388e19j", "Maryam@gmail.com", true, "مريم أحمد", "profiles/77082i72-995g-73be-2ggh-2h65a4g0f69h.jpeg", "عمر فاروق", false, null, "3456789012345678", "MARYAM@GMAIL.COM", "MARYAM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "073456789012", false, "9120593g-9763-7466-19bh-1394g34hg89i", "Female", false, "Maryam@gmail.com" },
                    { "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r", 0, "f50sg7vv-d3i9-3d2d-8e12-e4e6f0r5f86j", "Lina@gmail.com", true, "لينا رامي", "profiles/33448i48-667g-39be-8ggh-8h21a0g6f25h.png", "خالد عبد السميع", false, null, "9900112233445566", "LINA@GMAIL.COM", "LINA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "079900112233", false, "68082s1g-6431-5144-97bh-9173g23gh78i", "Female", false, "Lina@gmail.com" },
                    { "cb3cb7ca-1921-49fd-a11e-600b351b3df2", 0, "c76ae4f3-37a2-4707-b71b-f5d99f6f50da", "Salma@gmail.com", true, "عبدالله وائل", "profiles/Women in Business.jpeg", "حافظ", false, null, "30302901738376", "SALMA@GMAIL.COM", "SALMA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01029836539", false, "2121aa48-49d8-4b1e-841e-48a7e61b0863", "Male", false, "Salma@gmail.com" },
                    { "cb3cb7ca-1921-49fd-a11e-600b351b3df3", 0, "f58fbbd5-a0d4-460c-bc0d-5afb9a0adb63", "Jesseyd@gmail.com", true, "منة الله محمد", "profiles/9151a7a4-4fc2-4bb0-a427-f97f4127e661.jpeg", "مصطفي", false, null, "40415678901625", "JESSEYD@GMAIL.COM", "JESSEYD@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "07022670816", false, "f4dd9dcd-8ef8-40fa-b1ac-6a6caa133079", "Female", false, "Jesseyd@gmail.com" },
                    { "cb3cb7ca-1921-49fd-a11e-600b351b3df4", 0, "f58fbbd5-a0d4-460c-bc0d-5afb9a0adb63", "Jessey@gmail.com", true, "نانسي عصام", "profiles/9151a7a4-4fc2-4bb0-a427-f97f4127e661.jpeg", "محمد السيد", false, null, "40415678901625", "JESSEY@GMAIL.COM", "JESSEY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "07022670816", false, "f4dd9dcd-8ef8-40fa-b1ac-6a6caa133079", "Female", false, "Jessey@gmail.com" },
                    { "ce47a5ab-df14-416a-b500-9b544fa666a4", 0, "5d48db4f-16d7-418b-b97f-dbfe8616af56", "Nader@gmail.com", true, "سيف الدين", "profiles/Mari Juliano.jpeg", "حسام سلامة", false, null, "303020837616543", "NADER@GMAIL.COM", "NADER@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01147893547", false, "e68c1657-3cb1-4097-a45f-27c1a655c81f", "Male", false, "Nader@gmail.com" },
                    { "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s", 0, "g61th8ww-e4j0-4e3e-9f23-f5f7g1s6g97k", "Ramy@gmail.com", true, "رامي ناصر", "profiles/44559j59-778h-40cf-9hhi-9i32b1h7g36i.jpeg", "محمد عبد العظيم", false, null, "0011223344556677", "RAMY@GMAIL.COM", "RAMY@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "070011223344", false, "79193t2h-7542-6255-08ci-0284h34hi89j", "Male", false, "Ramy@gmail.com" },
                    { "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s", 0, "g059h266-e8jg-8e7e-2f67-f8f0g499f20k", "Khaled@gmail.com", true, "خالد محمود", "profiles/88093j83-006h-84cf-3hhi-3i76b5h1g70i.jpg", "سعيد عبد العزيز", false, null, "4567890123456789", "KHALED@GMAIL.COM", "KHALED@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "074567890123", false, "02316a4h-0874-8577-20ci-2405h45ih90j", "Male", false, "Khaled@gmail.com" },
                    { "df2ea217-2e82-48b9-9442-47556c1a9403", 0, "7e09e586-695e-44ad-86a9-f7b49ba3552b", "Ali@gmail.com", true, "ايمان ايمن", "profiles/Outdoor Portraits — San Francisco Bay Area's Premier Personal Brand and Headshot Photographer _ Alpa.jpeg", "السيد المتولي", false, null, "30308795612367", "ALI@GMAIL.COM", "ALI@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01134409876", false, "287317a5-2b4e-4193-ade4-9b03c843b021", "Female", false, "Ali@gmail.com" },
                    { "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t", 0, "h16ai377-f9kh-9f8f-3g78-g9g1h5a0g31l", "Nora@gmail.com", true, "نورا حسن", "profiles/99004k94-117i-95dg-4iij-4j87c6i2h81j.png", "محمود عبد الرحيم", false, null, "5678901234567890", "NORA@GMAIL.COM", "NORA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "075678901234", false, "13427b5i-1985-9688-31dj-3516i56ji01k", "Female", false, "Nora@gmail.com" },
                    { "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u", 0, "i27bj488-g0li-0g9g-4h89-h0h2i6b1h42m", "Omar@gmail.com", true, "عمر خالد", "profiles/00115l05-228j-06eh-5jjk-5k98d7j3i92k.jpeg", "ياسر محمد", false, null, "6789012345678901", "OMAR@GMAIL.COM", "OMAR@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "076789012345", false, "24538c6j-2096-0799-42ek-4627j67kj12l", "Male", false, "Omar@gmail.com" },
                    { "f89bca4a-8fc9-4259-a46d-22562907c27f", 0, "c615d822-a4fc-4a3a-8b23-b4b6c155b96a", "Mark@gmail.com", true, "يوسف محمد", "profiles/44050f40-662d-408b-9dda-9e3271d7c36e.jpeg", "حسن الشحات", false, null, "4042098715635491", "MARK@GMAIL.COM", "MARK@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "070901468297", false, "6909260d-6430-4133-868e-9091e01fe56f", "Male", false, "Mark@gmail.com" },
                    { "fc4df06f-05c2-4751-96c1-8040f2761b7f", 0, "30d973bd-092f-4869-ac70-0b1004519b48", "Mohamed@gmail.com", true, "سارة", "profiles/82ebaf90-31fe-40ef-8358-99823ce3881d.jpeg", "ابوزيد", false, null, "30309871265308", "MOHAMED@GMAIL.COM", "MOHAMED@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "01084670325", false, "4a5413d0-0b02-48f8-a24f-16b929d0af74", "Female", false, "Mohamed@gmail.com" },
                    { "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v", 0, "j38ck599-h1mj-1h0h-5i90-i1i3j7c2i53n", "Fatima@gmail.com", true, "فاطمة إبراهيم", "profiles/11226m16-339k-17fi-6kkl-6l09e8k4j03l.jpg", "علي محسن", false, null, "7890123456789012", "FATIMA@GMAIL.COM", "FATIMA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "077890123456", false, "35649d7k-3107-1800-53fl-5738k78lk23m", "Female", false, "Fatima@gmail.com" },
                    { "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w", 0, "k49dl6aa-i2nk-2i1i-6j01-j2j4k8d3j64o", "Yasser@gmail.com", true, "ياسر عبد الله", "profiles/22337n27-440l-28gj-7llm-7m10f9l5k14m.png", "مصطفى أحمد", false, null, "8901234567890123", "YASSER@GMAIL.COM", "YASSER@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "078901234567", false, "46750e8l-4218-2911-64gm-6849l89ml34n", "Male", false, "Yasser@gmail.com" },
                    { "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x", 0, "l50em7bb-j3ol-3j2j-7k12-k3k5l9e4k75p", "Aya@gmail.com", true, "آية محمد", "profiles/33448o38-551m-39hk-8mmn-8n21g0m6l25n.jpeg", "خالد عبد الكريم", false, null, "9012345678901234", "AYA@GMAIL.COM", "AYA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "079012345678", false, "57861f9m-5329-3022-75hn-7950m90nm45o", "Female", false, "Aya@gmail.com" },
                    { "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y", 0, "m61fn8cc-k4pm-4k3k-8l23-l4l6m0f5l86q", "Mustafa@gmail.com", true, "مصطفى علي", "profiles/44559p49-662n-40il-9nno-9o32h1n7m36o.jpg", "حسين محمود", false, null, "0123456789012345", "MUSTAFA@GMAIL.COM", "MUSTAFA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "070123456789", false, "68972g0n-6430-4133-86io-8061n01on56p", "Male", false, "Mustafa@gmail.com" },
                    { "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z", 0, "n72go9dd-l5qn-5l4l-9m34-m5m7n1g6m97r", "Hanaa@gmail.com", true, "هناء عبد الرحمن", "profiles/55660q50-773o-51jm-0oop-0p43i2o8n47p.png", "سعيد محمد", false, null, "1234567890123450", "HANAA@GMAIL.COM", "HANAA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "071234567890", false, "79083h1o-7541-5244-97jp-9172o12po67q", "Female", false, "Hanaa@gmail.com" },
                    { "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a", 0, "o83hp0ee-m6ro-6m5m-0n45-n6n8o2h7n08s", "Abdelrahman@gmail.com", true, "عبد الرحمن عماد", "profiles/66771r61-884p-62kn-1ppq-1q54j3p9o58q.jpeg", "ياسر فؤاد", false, null, "2345678901234501", "ABDELRAHMAN@GMAIL.COM", "ABDELRAHMAN@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "072345678901", false, "80194i2p-8652-6355-08kq-0283p23qp78r", "Male", false, "Abdelrahman@gmail.com" },
                    { "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b", 0, "p94iq1ff-n7sp-7n6n-1o56-o7o9p3i8o19t", "Iman@gmail.com", true, "إيمان حسين", "profiles/77882s72-995q-73lo-2qqr-2r65k4q0p69r.jpg", "محمود عبد الله", false, null, "3456789012345012", "IMAN@GMAIL.COM", "IMAN@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "073456789012", false, "91205j3q-9763-7466-19lr-1394q34qr89s", "Female", false, "Iman@gmail.com" },
                    { "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c", 0, "q05jr2gg-o8tq-8o7o-2p67-p8p0q4j9p20u", "MohamedAmin@gmail.com", true, "محمد أمين", "profiles/88993t83-006r-84mp-3rrs-3s76l5r1q70s.png", "عبد الحميد سليمان", false, null, "4567890123450123", "MOHAMEDAMIN@GMAIL.COM", "MOHAMEDAMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "074567890123", false, "02316k4r-0874-8577-20ms-2405r45rs90t", "Male", false, "MohamedAmin@gmail.com" },
                    { "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d", 0, "r16ks3hh-p9ur-9p8p-3q78-q9q1r5k0q31v", "Rana@gmail.com", true, "رنا وليد", "profiles/99004u94-117s-95nq-4sst-4t87m6s2r81t.jpeg", "عبد الغني محمد", false, null, "5678901234501234", "RANA@GMAIL.COM", "RANA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "075678901234", false, "13427l5s-1985-9688-31nt-3516s56st01u", "Female", false, "Rana@gmail.com" },
                    { "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e", 0, "s27lt4ii-q0vs-0q9q-4r89-r0r2s6l1r42w", "Waleed@gmail.com", true, "وليد كمال", "profiles/00115v05-228t-06or-5ttu-5u98n7t3s92u.jpg", "حسن عبد الرحمن", false, null, "6789012345012345", "WALEED@GMAIL.COM", "WALEED@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "076789012345", false, "24538m6t-2096-0799-42ou-4627t67tu12v", "Male", false, "Waleed@gmail.com" },
                    { "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f", 0, "t38mu5jj-r1wt-1r0r-5s90-s1s3t7m2s53x", "Salma3@gmail.com", true, "سلمى أحمد", "profiles/11226w16-339u-17ps-6uuv-6v09o8u4t03v.png", "عبد العزيز محمد", false, null, "7890123450123456", "SALMA3@GMAIL.COM", "SALMA3@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "077890123456", false, "35649n7u-3107-1800-53pv-5738u78uv23w", "Female", false, "Salma3@gmail.com" },
                    { "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g", 0, "u49nv6kk-s2xu-2s1s-6t01-t2t4u8n3t64y", "Abdelaziz@gmail.com", true, "عبد العزيز محمود", "profiles/22337x27-440v-28qt-7vvw-7w10p9v5u14w.jpeg", "خالد سعيد", false, null, "8901234501234567", "ABDELAZIZ@GMAIL.COM", "ABDELAZIZ@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "078901234567", false, "46750o8v-4218-2911-64qw-6849v89vw34x", "Male", false, "Abdelaziz@gmail.com" },
                    { "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h", 0, "v50ow7ll-t3yv-3t2t-7u12-u3u5v9o4u75z", "Mona@gmail.com", true, "منى حسام", "profiles/33448y38-551w-39ru-8wwx-8x21q0w6v25x.jpg", "مصطفى عبد الله", false, null, "9012345012345678", "MONA@GMAIL.COM", "MONA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "079012345678", false, "57861p9w-5329-3022-75rx-7950w90wx45y", "Female", false, "Mona@gmail.com" },
                    { "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i", 0, "w61px8mm-u4zw-4u3u-8v23-v4v6w0p5v86a", "Hossam@gmail.com", true, "حسام الدين", "profiles/44559z49-662x-40sv-9xxy-9y32r1x7w36y.png", "علي محمود", false, null, "0123450123456789", "HOSSAM@GMAIL.COM", "HOSSAM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "070123456789", false, "68972q0x-6430-4133-86sy-8061x01xy56z", "Male", false, "Hossam@gmail.com" },
                    { "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j", 0, "x62ky9nn-v5a1-5v4v-0w34-w6w8x2j7x08b", "Reem@gmail.com", true, "ريم أحمد", "profiles/55660a60-889y-51tw-0yyz-0z43s2y8x47z.jpeg", "عبد الفتاح محمد", false, null, "1122334455667788", "REEM@GMAIL.COM", "REEM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "071122334455", false, "80294k3y-8653-7366-19tz-1395y45yz90a", "Female", false, "Reem@gmail.com" },
                    { "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k", 0, "y73lz0oo-w6b2-6w5w-1x45-x7x9y3k8y19c", "Tarek@gmail.com", true, "طارق إسماعيل", "profiles/66771b71-990z-62ux-1zza-1a54t3z9y58a.jpg", "حسن عبد الوهاب", false, null, "2233445566778899", "TAREK@GMAIL.COM", "TAREK@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "072233445566", false, "91305l4z-9764-8477-20ua-2406z56za01b", "Male", false, "Tarek@gmail.com" },
                    { "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l", 0, "z84ma1pp-x7c3-7x6x-2y56-y8y0z4l9z20d", "Hadeer@gmail.com", true, "هدير كمال", "profiles/77882c82-001a-73vy-2aab-2b65u4a0z69b.png", "محمود عبد السلام", false, null, "3344556677889900", "HADEER@GMAIL.COM", "HADEER@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "073344556677", false, "02416m5a-0875-9588-31vb-3517a67ab12c", "Female", false, "Hadeer@gmail.com" },
                    { "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m", 0, "a95nb2qq-y8d4-8y7y-3z67-z9z1a5m0a31e", "Karim@gmail.com", true, "كريم سعد", "profiles/88993d93-112b-84wz-3bbc-3c76v5b1a70c.jpeg", "علي عبد الرازق", false, null, "4455667788990011", "KARIM@GMAIL.COM", "KARIM@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "074455667788", false, "13527n6b-1986-0699-42wc-4628b78bc23d", "Male", false, "Karim@gmail.com" },
                    { "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n", 0, "b06oc3rr-z9e5-9z8z-4a78-a0a2b6n1b42f", "Jana@gmail.com", true, "جنى وائل", "profiles/99004e04-223c-95xa-4ccd-4d87w6c2b81d.jpg", "محمد عبد الغفار", false, null, "5566778899001122", "JANA@GMAIL.COM", "JANA@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "075566778899", false, "24638o7c-2097-1700-53xd-5739c89cd34e", "Female", false, "Jana@gmail.com" },
                    { "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o", 0, "c17pd4ss-a0f6-0a9a-5b89-b1b3c7o2c53g", "Wael@gmail.com", true, "وائل نبيل", "profiles/00115f15-334d-06yb-5dde-5e98x7d3c92e.png", "حسين عبد الحليم", false, null, "6677889900112233", "WAEL@GMAIL.COM", "WAEL@GMAIL.COM", "AQAAAAIAAYagAAAAEN6vZ01506YX1ctq2EthavTlwjZTRO5AjuoQ5LDjMQ+cpfTdIRy0cPAFQfqq4zbWYA==", "076677889900", false, "35749p8d-3108-2811-64ye-6840d90de45f", "Male", false, "Wael@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10eb7637-95f4-45d2-b200-84dbb188ec41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "249aa6c5-d578-4517-8a42-48f24a7d959e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "357c8ce0-ed6e-4979-b1f9-5e0f6e90c9a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49a438ba-672d-41d5-97ba-5536ffbec2a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52511e3a-0690-45b0-9e52-02667a473b18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52511e3a-0690-45b0-9e52-02667a473c23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d577849-97d1-4984-bf96-6fee7d08c8be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "683211b1-1125-42a1-b148-a606a4ca4df3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b9b3e85-ce32-4944-9a46-601bb2b40000");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c30ae16-67eb-4ff2-858f-70aa79aaa3c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8766c317-1eaa-468a-b34d-59790c8eb915");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0e2f1e7-53e5-416f-b0b0-ca4668563233");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a12bc34d-5e6f-7g8h-9i0j-1k2l3m4n5o6p");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a78bc90d-1e2f-3g4h-5i6j-7k8l9m0n1o2p");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b23cd45e-6f7g-8h9i-0j1k-2l3m4n5o6p7q");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b89cd01e-2f3g-4h5i-6j7k-8l9m0n1o2p3q");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf2ee728-59af-45ec-9b70-e5f5e27eef8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c34de56f-7g8h-9i0j-1k2l-3m4n5o6p7q8r");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c90de12f-3g4h-5i6j-7k8l-9m0n1o2p3q4r");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb3cb7ca-1921-49fd-a11e-600b351b3df4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce47a5ab-df14-416a-b500-9b544fa666a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d01ef23g-4h5i-6j7k-8l9m-0n1o2p3q4r5s");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d45ef67g-8h9i-0j1k-2l3m-4n5o6p7q8r9s");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df2ea217-2e82-48b9-9442-47556c1a9403");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e56fg78h-9i0j-1k2l-3m4n-5o6p7q8r9s0t");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f67gh89i-0j1k-2l3m-4n5o-6p7q8r9s0t1u");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f89bca4a-8fc9-4259-a46d-22562907c27f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc4df06f-05c2-4751-96c1-8040f2761b7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "g78hi90j-1k2l-3m4n-5o6p-7q8r9s0t1u2v");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "h89ij01k-2l3m-4n5o-6p7q-8r9s0t1u2v3w");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "i90jk12l-3m4n-5o6p-7q8r-9s0t1u2v3w4x");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "j01kl23m-4n5o-6p7q-8r9s-0t1u2v3w4x5y");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k12lm34n-5o6p-7q8r-9s0t-1u2v3w4x5y6z");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "l23mn45o-6p7q-8r9s-0t1u-2v3w4x5y6z7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "m34no56p-7q8r-9s0t-1u2v-3w4x5y6z7a8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "n45op67q-8r9s-0t1u-2v3w-4x5y6z7a8b9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "o56pq78r-9s0t-1u2v-3w4x-5y6z7a8b9c0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "p67qr89s-0t1u-2v3w-4x5y-6z7a8b9c0d1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "q78rs90t-1u2v-3w4x-5y6z-7a8b9c0d1e2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "r89st01u-2v3w-4x5y-6z7a-8b9c0d1e2f3g");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s90tu12v-3w4x-5y6z-7a8b-9c0d1e2f3g4h");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t01uv23w-4x5y-6z7a-8b9c-0d1e2f3g4h5i");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u12vw34x-5y6z-7a8b-9c0d-1e2f3g4h5i6j");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "v23wx45y-6z7a-8b9c-0d1e-2f3g4h5i6j7k");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "w34xy56z-7a8b-9c0d-1e2f-3g4h5i6j7k8l");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x45yz67a-8b9c-0d1e-2f3g-4h5i6j7k8l9m");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "y56za78b-9c0d-1e2f-3g4h-5i6j7k8l9m0n");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "z67ab89c-0d1e-2f3g-4h5i-6j7k8l9m0n1o");
        }
    }
}
