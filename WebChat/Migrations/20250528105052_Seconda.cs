using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebChat.Migrations
{
    /// <inheritdoc />
    public partial class Seconda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Utenti_DestinatarioIDutente",
                table: "Messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Utenti_MittenteIDutente",
                table: "Messaggi");

            migrationBuilder.AlterColumn<uint>(
                name: "MittenteIDutente",
                table: "Messaggi",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(uint),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<uint>(
                name: "DestinatarioIDutente",
                table: "Messaggi",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(uint),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Utenti_DestinatarioIDutente",
                table: "Messaggi",
                column: "DestinatarioIDutente",
                principalTable: "Utenti",
                principalColumn: "IDutente",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Utenti_MittenteIDutente",
                table: "Messaggi",
                column: "MittenteIDutente",
                principalTable: "Utenti",
                principalColumn: "IDutente",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Utenti_DestinatarioIDutente",
                table: "Messaggi");

            migrationBuilder.DropForeignKey(
                name: "FK_Messaggi_Utenti_MittenteIDutente",
                table: "Messaggi");

            migrationBuilder.AlterColumn<uint>(
                name: "MittenteIDutente",
                table: "Messaggi",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u,
                oldClrType: typeof(uint),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<uint>(
                name: "DestinatarioIDutente",
                table: "Messaggi",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u,
                oldClrType: typeof(uint),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Utenti_DestinatarioIDutente",
                table: "Messaggi",
                column: "DestinatarioIDutente",
                principalTable: "Utenti",
                principalColumn: "IDutente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messaggi_Utenti_MittenteIDutente",
                table: "Messaggi",
                column: "MittenteIDutente",
                principalTable: "Utenti",
                principalColumn: "IDutente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
