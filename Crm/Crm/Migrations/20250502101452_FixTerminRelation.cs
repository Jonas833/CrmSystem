using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.Migrations
{
    /// <inheritdoc />
    public partial class FixTerminRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Termine",
                columns: table => new
                {
                    TerminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Betreff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KundeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termine", x => x.TerminId);
                    table.ForeignKey(
                        name: "FK_Termine_Kunden_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Termine_KundeId",
                table: "Termine",
                column: "KundeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Termine");
        }
    }
}
