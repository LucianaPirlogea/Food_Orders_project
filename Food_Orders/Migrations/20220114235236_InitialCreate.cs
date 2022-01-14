using Microsoft.EntityFrameworkCore.Migrations;

namespace Food_Orders.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nr_telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feluri_mancare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantitate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pret = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feluri_mancare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tip_pret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specific = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adrese",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numar = table.Column<int>(type: "int", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adrese", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adrese_Clienti_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comenzi",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Fel_mancareId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comenzi", x => new { x.ClientId, x.Fel_mancareId });
                    table.ForeignKey(
                        name: "FK_Comenzi_Clienti_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comenzi_Feluri_mancare_Fel_mancareId",
                        column: x => x.Fel_mancareId,
                        principalTable: "Feluri_mancare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalii_contacte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tel_mobil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel_fix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalii_contacte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalii_contacte_Restaurante_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meniuri",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Fel_mancareId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meniuri", x => new { x.RestaurantId, x.Fel_mancareId });
                    table.ForeignKey(
                        name: "FK_Meniuri_Feluri_mancare_Fel_mancareId",
                        column: x => x.Fel_mancareId,
                        principalTable: "Feluri_mancare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meniuri_Restaurante_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adrese_ClientID",
                table: "Adrese",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Comenzi_Fel_mancareId",
                table: "Comenzi",
                column: "Fel_mancareId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalii_contacte_RestaurantId",
                table: "Detalii_contacte",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meniuri_Fel_mancareId",
                table: "Meniuri",
                column: "Fel_mancareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adrese");

            migrationBuilder.DropTable(
                name: "Comenzi");

            migrationBuilder.DropTable(
                name: "Detalii_contacte");

            migrationBuilder.DropTable(
                name: "Meniuri");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Feluri_mancare");

            migrationBuilder.DropTable(
                name: "Restaurante");
        }
    }
}
