using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stradario.Migrations
{
    /// <inheritdoc />
    public partial class AddStrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "strade",
                columns: table => new
                {
                    IdStrada = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AidNodo = table.Column<uint>(type: "INTEGER", nullable: false),
                    BidNodo = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_strade", x => x.IdStrada);
                    table.ForeignKey(
                        name: "FK_strade_nodi_AidNodo",
                        column: x => x.AidNodo,
                        principalTable: "nodi",
                        principalColumn: "idNodo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_strade_nodi_BidNodo",
                        column: x => x.BidNodo,
                        principalTable: "nodi",
                        principalColumn: "idNodo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_strade_AidNodo",
                table: "strade",
                column: "AidNodo");

            migrationBuilder.CreateIndex(
                name: "IX_strade_BidNodo",
                table: "strade",
                column: "BidNodo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "strade");
        }
    }
}
