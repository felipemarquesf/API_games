using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games.Migrations
{
    /// <inheritdoc />
    public partial class campoSituacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Situacao",
                table: "Game",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Game");
        }
    }
}
