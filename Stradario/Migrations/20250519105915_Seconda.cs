using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stradario.Migrations
{
    /// <inheritdoc />
    public partial class Seconda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "archi",
                columns: table => new
                {
                    IdArco = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    A = table.Column<int>(type: "INTEGER", nullable: false),
                    B = table.Column<int>(type: "INTEGER", nullable: false),
                    Distanza = table.Column<int>(type: "INTEGER", nullable: false),
                    Creazione = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UltimaModifica = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_archi", x => x.IdArco);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "archi");
        }
    }
}
