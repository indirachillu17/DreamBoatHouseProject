using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack",
                column: "FeedbackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack",
                column: "UserId");
        }
    }
}
