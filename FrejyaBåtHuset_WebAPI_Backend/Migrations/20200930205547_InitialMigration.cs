using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Andraaktiviteter",
                columns: table => new
                {
                    AndraaktiviteterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherActivities = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActivitiesTiming = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Andraaktiviteter", x => x.AndraaktiviteterID);
                });

            migrationBuilder.CreateTable(
                name: "BåtHusetBokning",
                columns: table => new
                {
                    BåtHusetBokningID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscoverBoatHouse = table.Column<int>(nullable: false),
                    BoatStart = table.Column<DateTime>(nullable: false),
                    BoatEnd = table.Column<DateTime>(nullable: false),
                    OtherActivities = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    PriceOfTicket = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoOfPersons = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BåtHusetBokning", x => x.BåtHusetBokningID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Andraaktiviteter");

            migrationBuilder.DropTable(
                name: "BåtHusetBokning");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
