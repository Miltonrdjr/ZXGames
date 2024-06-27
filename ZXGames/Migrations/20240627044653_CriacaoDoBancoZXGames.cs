using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZXGames.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDoBancoZXGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeVenda = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venda");
        }
    }
}
