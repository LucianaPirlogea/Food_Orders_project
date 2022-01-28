using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_Orders.Migrations
{
    public partial class FinalCreate_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clienti",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clienti");
        }
    }
}
