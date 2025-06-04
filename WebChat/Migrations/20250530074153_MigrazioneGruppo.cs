using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebChat.Migrations
{
    /// <inheritdoc />
    public partial class MigrazioneGruppo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GruppoIDgruppo",
                table: "Utenti",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GruppoIDgruppo",
                table: "Messaggi",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "UtenteIDutente",
                table: "Messaggi",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "UtenteIDutente1",
                table: "Messaggi",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gruppi",
                columns: table => new
                {
                    IDgruppo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: false),
                    Creazione = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gruppi", x => x.IDgruppo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Utenti_GruppoIDgruppo",
                table: "Utenti",
                column: "GruppoIDgruppo");

            migrationBuilder.CreateIndex(
                name: "IX_Messaggi_GruppoIDgruppo",
                table: "Messaggi",
                column: "GruppoIDgruppo");

            migrationBuilder.CreateIndex(
                name: "IX_Messaggi_UtenteIDutente",
                table: "Messaggi",
                column: "UtenteIDutente");

            migrationBuilder.CreateIndex(
                name: "IX_Messaggi_UtenteIDutente1",
                table: "Messaggi",
                column: "UtenteIDutente1");

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Gruppi_GruppoIDgruppo",
                table: "Messaggi",
                column: "GruppoIDgruppo",
                principalTable: "Gruppi",
                principalColumn: "IDgruppo");

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Utenti_UtenteIDutente",
                table: "Messaggi",
                column: "UtenteIDutente",
                principalTable: "Utenti",
                principalColumn: "IDutente");

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Utenti_UtenteIDutente1",
                table: "Messaggi",
                column: "UtenteIDutente1",
                principalTable: "Utenti",
                principalColumn: "IDutente");

            migrationBuilder.AddForeignKey(
                name: "FK_Utenti_Gruppi_GruppoIDgruppo",
                table: "Utenti",
                column: "GruppoIDgruppo",
                principalTable: "Gruppi",
                principalColumn: "IDgruppo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Gruppi_GruppoIDgruppo",
                table: "Messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Utenti_UtenteIDutente",
                table: "Messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Utenti_UtenteIDutente1",
                table: "Messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_Utenti_Gruppi_GruppoIDgruppo",
                table: "Utenti");

            migrationBuilder.DropTable(
                name: "Gruppi");

            migrationBuilder.DropIndex(
                name: "IX_Utenti_GruppoIDgruppo",
                table: "Utenti");

            migrationBuilder.DropIndex(
                name: "IX_Messaggi_GruppoIDgruppo",
                table: "Messaggi");

            migrationBuilder.DropIndex(
                name: "IX_Messaggi_UtenteIDutente",
                table: "Messaggi");

            migrationBuilder.DropIndex(
                name: "IX_Messaggi_UtenteIDutente1",
                table: "Messaggi");

            migrationBuilder.DropColumn(
                name: "GruppoIDgruppo",
                table: "Utenti");

            migrationBuilder.DropColumn(
                name: "GruppoIDgruppo",
                table: "Messaggi");

            migrationBuilder.DropColumn(
                name: "UtenteIDutente",
                table: "Messaggi");

            migrationBuilder.DropColumn(
                name: "UtenteIDutente1",
                table: "Messaggi");
        }
    }
}
