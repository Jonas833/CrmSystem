using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.Migrations
{
    /// <inheritdoc />
    public partial class AddNeueKundenSpalten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branche",
                table: "Kunden",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kunden",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telenummer",
                table: "Kunden",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unternehmen",
                table: "Kunden",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branche",
                table: "Kunden");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kunden");

            migrationBuilder.DropColumn(
                name: "Telenummer",
                table: "Kunden");

            migrationBuilder.DropColumn(
                name: "Unternehmen",
                table: "Kunden");
        }
    }
}
