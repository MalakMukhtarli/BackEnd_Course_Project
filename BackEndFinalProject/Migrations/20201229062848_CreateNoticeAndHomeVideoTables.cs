using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinalProject.Migrations
{
    public partial class CreateNoticeAndHomeVideoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoLink = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeVideos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedTime = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HomeVideos",
                columns: new[] { "Id", "VideoLink" },
                values: new object[] { 1, "https://www.youtube.com/watch?v=to6Ghf8UL7o" });

            migrationBuilder.InsertData(
                table: "Notices",
                columns: new[] { "Id", "AddedTime", "Content", "DeletedTime", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete", null, false },
                    { 2, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete", null, false },
                    { 3, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete", null, false },
                    { 4, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete", null, false },
                    { 5, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete", null, false },
                    { 6, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 - I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete", null, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeVideos");

            migrationBuilder.DropTable(
                name: "Notices");
        }
    }
}
