using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebChat.Migrations
{
    /// <inheritdoc />
    public partial class Prima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    IDutente = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.IDutente);
                });

            migrationBuilder.CreateTable(
                name: "Messaggi",
                columns: table => new
                {
                    IDmessaggio = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MittenteIDutente = table.Column<uint>(type: "INTEGER", nullable: false),
                    DestinatarioIDutente = table.Column<uint>(type: "INTEGER", nullable: false),
                    Contenuto = table.Column<string>(type: "TEXT", nullable: false),
                    Invio = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messaggi", x => x.IDmessaggio);
                    table.ForeignKey(
                        name: "FK_Messaggi_Utenti_DestinatarioIDutente",
                        column: x => x.DestinatarioIDutente,
                        principalTable: "Utenti",
                        principalColumn: "IDutente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messaggi_Utenti_MittenteIDutente",
                        column: x => x.MittenteIDutente,
                        principalTable: "Utenti",
                        principalColumn: "IDutente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messaggi_DestinatarioIDutente",
                table: "Messaggi",
                column: "DestinatarioIDutente");

            migrationBuilder.CreateIndex(
                name: "IX_Messaggi_MittenteIDutente",
                table: "Messaggi",
                column: "MittenteIDutente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messaggi");

            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}
