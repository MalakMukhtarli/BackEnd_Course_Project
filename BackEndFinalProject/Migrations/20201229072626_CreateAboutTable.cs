using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinalProject.Migrations
{
    public partial class CreateAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 150, nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "Image", "Title" },
                values: new object[] { 1, "<p>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness</p><p class='hidden-sm'>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>", "about.png", "<span>EDUHOME</span> the best education theme for you" });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "Image", "Title" },
                values: new object[] { 2, "<p>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness</p><p class='hidden-sm'>I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>", "about.png", "WELCOME TO <span>EDUHOME</span>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
