using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.Migrations
{
    /// <inheritdoc />
    public partial class AddRechnungenTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rechungen");

            migrationBuilder.CreateTable(
                name: "Rechnungen",
                columns: table => new
                {
                    RechnungId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RechnungNr = table.Column<int>(type: "int", nullable: false),
                    RechnungsBetrag = table.Column<int>(type: "int", nullable: false),
                    ErstellDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KundeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechnungen", x => x.RechnungId);
                    table.ForeignKey(
                        name: "FK_Rechnungen_Kunden_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rechnungen_KundeId",
                table: "Rechnungen",
                column: "KundeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rechnungen");

            migrationBuilder.CreateTable(
                name: "Rechungen",
                columns: table => new
                {
                    RechnungenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KundeId = table.Column<int>(type: "int", nullable: false),
                    RechnungsBetrag = table.Column<int>(type: "int", nullable: false),
                    RechnungsNr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechungen", x => x.RechnungenId);
                    table.ForeignKey(
                        name: "FK_Rechungen_Kunden_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rechungen_KundeId",
                table: "Rechungen",
                column: "KundeId");
        }
    }
}
