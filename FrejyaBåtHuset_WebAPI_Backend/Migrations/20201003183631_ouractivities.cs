using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class ouractivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivitiesTiming",
                table: "Andraaktiviteter");

            migrationBuilder.DropColumn(
                name: "OtherActivities",
                table: "Andraaktiviteter");

            migrationBuilder.AddColumn<string>(
                name: "ActivitiesTime",
                table: "Andraaktiviteter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivityType",
                table: "Andraaktiviteter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOfactivity",
                table: "Andraaktiviteter",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivitiesTime",
                table: "Andraaktiviteter");

            migrationBuilder.DropColumn(
                name: "ActivityType",
                table: "Andraaktiviteter");

            migrationBuilder.DropColumn(
                name: "NameOfactivity",
                table: "Andraaktiviteter");

            migrationBuilder.AddColumn<string>(
                name: "ActivitiesTiming",
                table: "Andraaktiviteter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherActivities",
                table: "Andraaktiviteter",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
