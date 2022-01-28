using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_Orders.Migrations
{
    public partial class FinalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adrese_AspNetUsers_UserId",
                table: "Adrese");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_AspNetUsers_UserId",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "Nr_telefon",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nume",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comenzi",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Adrese",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Adrese_UserId",
                table: "Adrese",
                newName: "IX_Adrese_ClientId");

            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nr_telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Adrese_Clienti_ClientId",
                table: "Adrese",
                column: "ClientId",
                principalTable: "Clienti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Clienti_ClientId",
                table: "Comenzi",
                column: "ClientId",
                principalTable: "Clienti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adrese_Clienti_ClientId",
                table: "Adrese");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Clienti_ClientId",
                table: "Comenzi");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Comenzi",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Adrese",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Adrese_ClientId",
                table: "Adrese",
                newName: "IX_Adrese_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Nr_telefon",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adrese_AspNetUsers_UserId",
                table: "Adrese",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_AspNetUsers_UserId",
                table: "Comenzi",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
