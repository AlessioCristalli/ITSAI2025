using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stradario.Migrations
{
    /// <inheritdoc />
    public partial class Prima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nodi",
                columns: table => new
                {
                    idNodo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    X = table.Column<double>(type: "REAL", nullable: false),
                    Y = table.Column<double>(type: "REAL", nullable: false),
                    Creazione = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UltimaModifica = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nodi", x => x.idNodo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nodi");
        }
    }
}
