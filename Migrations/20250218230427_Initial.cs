using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NomeDoJogo = table.Column<string>(type: "TEXT", nullable: false),
                    NomeDaEmpresa = table.Column<string>(type: "TEXT", nullable: false),
                    EstiloDoJogo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
