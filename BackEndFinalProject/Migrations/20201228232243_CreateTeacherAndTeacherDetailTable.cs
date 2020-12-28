using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinalProject.Migrations
{
    public partial class CreateTeacherAndTeacherDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Surname = table.Column<string>(maxLength: 200, nullable: false),
                    Position = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(maxLength: 150, nullable: false),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About = table.Column<string>(nullable: false),
                    Degree = table.Column<string>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    Hobbies = table.Column<string>(nullable: false),
                    Faculty = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Skype = table.Column<string>(nullable: false),
                    Language = table.Column<int>(nullable: false),
                    TeamLeader = table.Column<int>(nullable: false),
                    Development = table.Column<int>(nullable: false),
                    Design = table.Column<int>(nullable: false),
                    Innovation = table.Column<int>(nullable: false),
                    Communication = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherDetails_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "blog1.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "blog2.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "blog3.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "blog4.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "blog5.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "blog6.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "blog7.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "blog8.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "blog9.jpg");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "event5.jpg");

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DeletedTime", "Facebook", "Image", "IsDeleted", "Name", "Pinterest", "Position", "Surname", "Twitter", "Vimeo" },
                values: new object[,]
                {
                    { 12, null, "#", "teacher12.jpg", false, "SALINA", "#", "Associate Professor", "GOMAZE", "#", "#" },
                    { 11, null, "#", "teacher11.jpg", false, "KEVIN", "#", "Associate Professor", "WILLIAMS", "#", "#" },
                    { 9, null, "#", "teacher9.jpg", false, "STUART", "#", "Associate Professor", "KELVIN", "#", "#" },
                    { 8, null, "#", "teacher8.jpg", false, "NAIL", "#", "Associate Professor", "ANDERSON", "#", "#" },
                    { 7, null, "#", "teacher7.jpg", false, "JULIA", "#", "Associate Professor", "WILLIAMS", "#", "#" },
                    { 6, null, "#", "teacher6.jpg", false, "STEPHEN", "#", "Associate Professor", "FLEMING", "#", "#" },
                    { 5, null, "#", "teacher5.jpg", false, "JASMIN", "#", "Associate Professor", "SMITH", "#", "#" },
                    { 4, null, "#", "teacher2.jpg", false, "EAMILY", "#", "Associate Professor", "CRISTIAN", "#", "#" },
                    { 3, null, "#", "teacher1.jpg", false, "KEVIN", "#", "Associate Professor", "WILLIAMS", "#", "#" },
                    { 2, null, "#", "forever.jpg", false, "Kamran", "#", "Associate Professor", "Jabiyev", "#", "#" },
                    { 10, null, "#", "teacher10.jpg", false, "STUART", "#", "Associate Professor", "KELVIN", "#", "#" },
                    { 1, null, "#", "teacher4.jpg", false, "Ömür", "#", "Associate Professor", "Jabiyeva", "#", "#" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDetails",
                columns: new[] { "Id", "About", "Communication", "Degree", "Design", "Development", "Experience", "Faculty", "Hobbies", "Innovation", "Language", "Mail", "Phone", "Skype", "TeacherId", "TeamLeader" },
                values: new object[,]
                {
                    { 1, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 110, "PHD in Micro Biology", 110, 110, "5 years experience", "Developer, Department of Micro Biology", "Coding, Ballerina, music, travelling, catching fish", 110, 110, "omurjb@code.az", "(+125) 5896 548 9874", "stuart.k", 1, 110 },
                    { 2, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 95, "PHD in Micro Biology", 95, 95, "25 years experience", "IT, Department of Micro Biology", "Eat Fish, Keep Students Sleepless:))), music, travelling, catching fish", 95, 50, "kamranjb@code.az", "(+125) 5896 548 9874", "stuart.k", 2, 95 },
                    { 3, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart3@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 3, 85 },
                    { 4, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart4@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 4, 85 },
                    { 5, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart5@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 5, 85 },
                    { 6, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart6@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 6, 85 },
                    { 7, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart7@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 7, 85 },
                    { 8, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart8@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 8, 85 },
                    { 9, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart9@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 9, 85 },
                    { 10, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart10@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 10, 85 },
                    { 11, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart11@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 11, 85 },
                    { 12, "I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas", 73, "PHD in Micro Biology", 75, 80, "7 years experience", "Din, Department of Micro Biology", "music, travelling, catching fish", 79, 30, "stuart12@eduhome.com", "(+125) 5896 548 9874", "stuart.k", 12, 85 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherDetails");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "event-details.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "event6.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "event7.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "event8.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "event9.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "event10.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "event11.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "event12.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "event13.jpg");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "event-details.jpg");
        }
    }
}
