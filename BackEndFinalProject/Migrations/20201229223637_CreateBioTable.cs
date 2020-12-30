using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinalProject.Migrations
{
    public partial class CreateBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmallLogo = table.Column<string>(maxLength: 150, nullable: false),
                    BigLogo = table.Column<string>(maxLength: 150, nullable: false),
                    About = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    AdditionalPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Webpage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bios",
                columns: new[] { "Id", "About", "AdditionalPhone", "Address", "BigLogo", "Email", "Facebook", "Phone", "Pinterest", "SmallLogo", "Twitter", "Vimeo", "Webpage" },
                values: new object[] { 1, "I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system.", "+880  659  785  658  98", "City, Roadno 785 New York", "footer-logo.png", "info@eduhome.com", "#", "+880  548  986  898  87", "#", "logo2.png", "#", "#", "www.eduhome.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bios");
        }
    }
}
