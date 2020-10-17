using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Andraaktiviteter",
                columns: table => new
                {
                    AndraaktiviteterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(nullable: true),
                    ActivityTime = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                    //ActivityType = table.Column<string>(nullable: true)
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
                    BoatTripPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BoatTripDate = table.Column<DateTime>(nullable: false),
                    BoatStartTime = table.Column<string>(nullable: true),
                    BoatEndTime = table.Column<string>(nullable: true),
                    OtherActivities = table.Column<string>(nullable: true),
                    ActivitiesTiming = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    PriceOfTicket = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Beverages = table.Column<string>(nullable: true)
                    //NoOfPersons = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BåtHusetBokning", x => x.BåtHusetBokningID);
                });

            migrationBuilder.CreateTable(
                name: "BåtHusetBokningTransaction",
                columns: table => new
                {
                    BåtHusetBokningTransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DiscoverBoatHouse = table.Column<int>(nullable: false),
                    BoatTripPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BoatTripDate = table.Column<DateTime>(nullable: false),
                    BoatStartTime = table.Column<string>(nullable: true),
                    BoatEndTime = table.Column<string>(nullable: true),
                    OtherActivities = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    Beverages = table.Column<string>(nullable: true),
                    NoOfPersons = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BåtHusetBokningTransaction", x => x.BåtHusetBokningTransactionID);
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
                name: "BåtHusetBokningTransaction");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
