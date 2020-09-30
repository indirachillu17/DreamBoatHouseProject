using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class Andraaktiviteter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Andraaktiviteter");
            migrationBuilder.CreateTable(
                name: "Andraaktiviteter",
                columns: table => new
                {
                    AndraaktiviteterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherActivities = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ActivitiesTiming = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Andraaktiviteter", x => x.AndraaktiviteterID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Andraaktiviteter");

            migrationBuilder.CreateTable(
               name: "Andraaktiviteter",
               columns: table => new
               {
                   AndraaktiviteterID = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   OtherActivities = table.Column<string>(nullable: true),
                   Price = table.Column<decimal>(nullable: false),
                   ActivitiesTiming = table.Column<string>(nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Andraaktiviteter", x => x.AndraaktiviteterID);
               });
        }
    }
}
