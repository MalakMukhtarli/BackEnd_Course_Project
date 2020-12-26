using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinalProject.Migrations
{
    public partial class CreateSliderTableFirstMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 150, nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true),
                    Subtitle = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 1, "slider3.jpg", "I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system", "<h3>EDUCATION MAKES </h3><h2> PROPER HUMANITY </h2>" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 2, "slider2.jpg", "I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system", "<h3>EDUCATION MAKES </h3><h2> PROPER HUMANITY </h2>" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 3, "slider1.jpg", "I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system", "<h3>EDUCATION MAKES </h3><h2> PROPER HUMANITY </h2>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
