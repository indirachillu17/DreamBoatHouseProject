using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrejyaBåtHuset_WebAPI_Backend.Migrations
{
    public partial class BåtHusetBokningTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "BåtHusetBokningTransaction");
           
            migrationBuilder.CreateTable(
                name: "BåtHusetBokningTransaction",
                columns: table => new
                {
                    BåtHusetBokningTransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DiscoverBoatHouse = table.Column<int>(nullable: false),
                    BoatTripPrice = table.Column<decimal>(nullable: false),
                    BoatTripDate = table.Column<DateTime>(nullable: false),
                    BoatStartTime = table.Column<string>(nullable: true),
                    BoatEndTime = table.Column<string>(nullable: true),
                    OtherActivities = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    Beverages = table.Column<string>(nullable: true),
                    NoOfPersons = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BåtHusetBokningTransaction", x => x.BåtHusetBokningTransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropTable(
              name: "BåtHusetBokningTransaction");

            migrationBuilder.CreateTable(
                name: "BåtHusetBokningTransaction",
                columns: table => new
                {
                    BåtHusetBokningTransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DiscoverBoatHouse = table.Column<int>(nullable: false),
                    BoatTripPrice = table.Column<decimal>(nullable: false),
                    BoatTripDate = table.Column<DateTime>(nullable: false),
                    BoatStartTime = table.Column<string>(nullable: true),
                    BoatEndTime = table.Column<string>(nullable: true),
                    OtherActivities = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    Beverages = table.Column<string>(nullable: true),
                    NoOfPersons = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BåtHusetBokningTransaction", x => x.BåtHusetBokningTransactionID);
                });
            //        migrationBuilder.DropTable(
            //            name: "BåtHusetBokningTransaction");

            //        migrationBuilder.DropColumn(
            //            name: "Beverages",
            //            table: "BåtHusetBokning");

            //        migrationBuilder.DropColumn(
            //            name: "BoatEndTime",
            //            table: "BåtHusetBokning");

            //        migrationBuilder.DropColumn(
            //            name: "BoatStartTime",
            //            table: "BåtHusetBokning");

            //        migrationBuilder.DropColumn(
            //            name: "BoatTripDate",
            //            table: "BåtHusetBokning");

            //        migrationBuilder.DropColumn(
            //            name: "BoatTripPrice",
            //            table: "BåtHusetBokning");

            //        migrationBuilder.AddColumn<DateTime>(
            //            name: "BoatEnd",
            //            table: "BåtHusetBokning",
            //            type: "datetime2",
            //            nullable: false,
            //            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //        migrationBuilder.AddColumn<DateTime>(
            //            name: "BoatStart",
            //            table: "BåtHusetBokning",
            //            type: "datetime2",
            //            nullable: false,
            //            defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            //    }
            //}
        }
    }
}