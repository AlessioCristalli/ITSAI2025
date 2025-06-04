using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stradario.Migrations
{
    /// <inheritdoc />
    public partial class ultimaMigrazione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_strade_nodi_AidNodo",
                table: "strade");

            migrationBuilder.DropForeignKey(
                name: "FK_strade_nodi_BidNodo",
                table: "strade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_strade",
                table: "strade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nodi",
                table: "nodi");

            migrationBuilder.RenameTable(
                name: "strade",
                newName: "Strade");

            migrationBuilder.RenameTable(
                name: "nodi",
                newName: "Nodi");

            migrationBuilder.RenameColumn(
                name: "BidNodo",
                table: "Strade",
                newName: "BIDnodo");

            migrationBuilder.RenameColumn(
                name: "AidNodo",
                table: "Strade",
                newName: "AIDnodo");

            migrationBuilder.RenameColumn(
                name: "IdStrada",
                table: "Strade",
                newName: "IDstrada");

            migrationBuilder.RenameIndex(
                name: "IX_strade_BidNodo",
                table: "Strade",
                newName: "IX_Strade_BIDnodo");

            migrationBuilder.RenameIndex(
                name: "IX_strade_AidNodo",
                table: "Strade",
                newName: "IX_Strade_AIDnodo");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Nodi",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "idNodo",
                table: "Nodi",
                newName: "IDnodo");

            migrationBuilder.RenameColumn(
                name: "IdArco",
                table: "archi",
                newName: "IDarco");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Strade",
                table: "Strade",
                column: "IDstrada");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nodi",
                table: "Nodi",
                column: "IDnodo");

            migrationBuilder.AddForeignKey(
                name: "FK_Strade_Nodi_AIDnodo",
                table: "Strade",
                column: "AIDnodo",
                principalTable: "Nodi",
                principalColumn: "IDnodo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strade_Nodi_BIDnodo",
                table: "Strade",
                column: "BIDnodo",
                principalTable: "Nodi",
                principalColumn: "IDnodo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Strade_Nodi_AIDnodo",
                table: "Strade");

            migrationBuilder.DropForeignKey(
                name: "FK_Strade_Nodi_BIDnodo",
                table: "Strade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Strade",
                table: "Strade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nodi",
                table: "Nodi");

            migrationBuilder.RenameTable(
                name: "Strade",
                newName: "strade");

            migrationBuilder.RenameTable(
                name: "Nodi",
                newName: "nodi");

            migrationBuilder.RenameColumn(
                name: "BIDnodo",
                table: "strade",
                newName: "BidNodo");

            migrationBuilder.RenameColumn(
                name: "AIDnodo",
                table: "strade",
                newName: "AidNodo");

            migrationBuilder.RenameColumn(
                name: "IDstrada",
                table: "strade",
                newName: "IdStrada");

            migrationBuilder.RenameIndex(
                name: "IX_Strade_BIDnodo",
                table: "strade",
                newName: "IX_strade_BidNodo");

            migrationBuilder.RenameIndex(
                name: "IX_Strade_AIDnodo",
                table: "strade",
                newName: "IX_strade_AidNodo");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "nodi",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "IDnodo",
                table: "nodi",
                newName: "idNodo");

            migrationBuilder.RenameColumn(
                name: "IDarco",
                table: "archi",
                newName: "IdArco");

            migrationBuilder.AddPrimaryKey(
                name: "PK_strade",
                table: "strade",
                column: "IdStrada");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nodi",
                table: "nodi",
                column: "idNodo");

            migrationBuilder.AddForeignKey(
                name: "FK_strade_nodi_AidNodo",
                table: "strade",
                column: "AidNodo",
                principalTable: "nodi",
                principalColumn: "idNodo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_strade_nodi_BidNodo",
                table: "strade",
                column: "BidNodo",
                principalTable: "nodi",
                principalColumn: "idNodo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
