using Microsoft.EntityFrameworkCore.Migrations;

namespace Mystays.TripAdvisor.Business.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Language_ID",
                table: "Location",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Location_Language_ID",
                table: "Location",
                column: "Language_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Language_Language_ID",
                table: "Location",
                column: "Language_ID",
                principalTable: "Language",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Language_Language_ID",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_Language_ID",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Language_ID",
                table: "Location");
        }
    }
}
