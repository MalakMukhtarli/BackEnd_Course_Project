using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndFinalProject.Migrations
{
    public partial class AddedIsDeletedColumnToCategoryAndSubscribeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Subscribers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_Email",
                table: "Subscribers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Subscribers_Email",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");
        }
    }
}
