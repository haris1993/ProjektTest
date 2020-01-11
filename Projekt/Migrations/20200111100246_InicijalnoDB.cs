using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class InicijalnoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opstina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Drzava = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opstina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    JedinicaMjere = table.Column<string>(nullable: true),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    PDVBroj = table.Column<string>(nullable: true),
                    OpstinaRodjenjaId = table.Column<int>(nullable: false),
                    OpstinaPrebivalistaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupac_Opstina_OpstinaPrebivalistaId",
                        column: x => x.OpstinaPrebivalistaId,
                        principalTable: "Opstina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Kupac_Opstina_OpstinaRodjenjaId",
                        column: x => x.OpstinaRodjenjaId,
                        principalTable: "Opstina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    KupacId = table.Column<int>(nullable: false),
                    Iznos = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faktura_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StavkaFakture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    FakturaId = table.Column<int>(nullable: false),
                    ProizvodId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaFakture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaFakture_Faktura_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Faktura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_StavkaFakture_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_KupacId",
                table: "Faktura",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_OpstinaPrebivalistaId",
                table: "Kupac",
                column: "OpstinaPrebivalistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_OpstinaRodjenjaId",
                table: "Kupac",
                column: "OpstinaRodjenjaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaFakture_FakturaId",
                table: "StavkaFakture",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaFakture_ProizvodId",
                table: "StavkaFakture",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkaFakture");

            migrationBuilder.DropTable(
                name: "Faktura");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "Opstina");
        }
    }
}
