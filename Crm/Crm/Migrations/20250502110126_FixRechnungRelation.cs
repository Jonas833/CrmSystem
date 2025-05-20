using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.Migrations
{
    /// <inheritdoc />
    public partial class FixRechnungRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Anzahlverkäufe",
                table: "Kunden",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GesamtUmsatz",
                table: "Kunden",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rechungen",
                columns: table => new
                {
                    RechnungenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RechnungsNr = table.Column<int>(type: "int", nullable: false),
                    RechnungsBetrag = table.Column<int>(type: "int", nullable: false),
                    KundeId = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rechungen");

            migrationBuilder.DropColumn(
                name: "Anzahlverkäufe",
                table: "Kunden");

            migrationBuilder.DropColumn(
                name: "GesamtUmsatz",
                table: "Kunden");
        }
    }
}
