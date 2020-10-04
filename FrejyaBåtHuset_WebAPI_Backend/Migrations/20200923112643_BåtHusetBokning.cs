using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class BåtHusetBokning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
               name: "BåtHusetBokning");
            migrationBuilder.CreateTable(
                name: "BåtHusetBokning",
                columns: table => new
                {
                    BåtHusetBokningID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscoverBoatHouse = table.Column<int>(nullable: false),
                    BoatTripPrice = table.Column<decimal>(nullable: false),
                    BoatTripDate = table.Column<DateTime>(nullable: false),
                    BoatStartTime = table.Column<string>(nullable: true),
                    BoatEndTime = table.Column<string>(nullable: true),
                    OtherActivities = table.Column<string>(nullable: true),
                    ActivitiesTiming = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    PriceOfTicket = table.Column<decimal>(nullable: false),
                    Beverages= table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BåtHusetBokning", x => x.BåtHusetBokningID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BåtHusetBokning");

            migrationBuilder.CreateTable(
                            name: "BåtHusetBokning",
                    columns: table => new
                    {
                        BåtHusetBokningID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                        DiscoverBoatHouse = table.Column<int>(nullable: false),
                        BoatTripPrice = table.Column<decimal>(nullable: false),
                        BoatTripDate = table.Column<DateTime>(nullable: false),
                        BoatStartTime = table.Column<string>(nullable: true),
                        BoatEndTime = table.Column<string>(nullable: true),
                        OtherActivities = table.Column<string>(nullable: true),
                        ActivitiesTiming = table.Column<string>(nullable: true),
                        Restaurant = table.Column<string>(nullable: true),
                        PriceOfTicket = table.Column<decimal>(nullable: false),
                        Beverages = table.Column<string>(nullable: true)

                    },
                     constraints: table =>
                    {
                        table.PrimaryKey("PK_BåtHusetBokning", x => x.BåtHusetBokningID);
                    });

        }
    }
}
