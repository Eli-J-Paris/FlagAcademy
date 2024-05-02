using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlagAcademy.Migrations
{
    /// <inheritdoc />
    public partial class GameTrackerModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "current_question",
                table: "game_trackers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "game_length",
                table: "game_trackers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "current_question",
                table: "game_trackers");

            migrationBuilder.DropColumn(
                name: "game_length",
                table: "game_trackers");
        }
    }
}
