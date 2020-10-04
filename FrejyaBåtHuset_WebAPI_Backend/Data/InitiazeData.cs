using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FrejyaBåtHuset_WebAPI_Backend.Data
{
    public class InitiazeData
    {
        static FrejyaBåtHuset_WebAPI_BackendContext  _context;
        public static void SeedData(FrejyaBåtHuset_WebAPI_BackendContext dbContext)
        {
            _context = dbContext;


            //Deletes database completly.
            //_context.Database.EnsureDeleted();

            //Apply all migrations automatically
            _context.Database.Migrate();

            //Seed your data in tables
            if (_context.Users.Count() <= 0)
            {
                SeedUsersData();
            }

            if (_context.BåtHusetBokning.Count() <= 0)
            {
                SeedBåtHusetBokningData();
            }
            if (_context.Andraaktiviteter.Count() <= 0)
            {
                SeedAndraaktiviteterData();
            }

            if (_context.BåtHusetBokningTransaction.Count() <= 0)
            {
                SeedBåtHusetBokningTransactionData();
            }
        }
        

        private static void SeedUsersData()
        {
            List<User> users = new List<User>();
            users.Add(new User() { EmailId = "abc@ab.com", Password = "abc", UserName = "abc", UserType = "user" });
            users.Add(new User() { EmailId = "nayana@ab.com", Password = "nayana", UserName = "nayana", UserType = "admin" });

            _context.Users.AddRange(users);
            _context.SaveChanges();
        }

        private static void SeedBåtHusetBokningData()
        {
            List<BåtHusetBokning> båtHusetBokning = new List<BåtHusetBokning>();
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse=1 ,BoatTripPrice=350, BoatTripDate=Convert.ToDateTime("2020-12-23"), BoatStartTime=" 10:00:00" ,BoatEndTime = " 19:00:00",OtherActivities="Barn-Activities ", ActivitiesTiming = "10am-12pm",Restaurant ="Non-Vegeterian Food(200Kr)", PriceOfTicket = 450,Beverages="Water bottle" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00",  OtherActivities = "Spa-Center", ActivitiesTiming = "13-14pm", Restaurant = "Vegeterian Food(150Kr)", PriceOfTicket = 1000, Beverages = "Beer" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00",  OtherActivities = "Fish Pedicure and Manicure", ActivitiesTiming = "14-15pm", Restaurant = "Non-Vegeterian Starters(100kr)", PriceOfTicket = 1500,Beverages= "Coffee" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00",  OtherActivities = "Dance Show", ActivitiesTiming = "15-16pm",Restaurant = " Vegeterian Starters(190kr)", PriceOfTicket = 750, Beverages = "Cold drinks" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Singing Concert", ActivitiesTiming = "16-17pm", Restaurant = " ", PriceOfTicket = 1200 , Beverages = "Wine" });
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Magic Show", ActivitiesTiming = "17-18pm", Restaurant = " ", PriceOfTicket = 600 ,Beverages="Tea"});
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Chess", ActivitiesTiming = "18-19pm", Restaurant = " ", PriceOfTicket = 450, Beverages = "Vodka" });


            _context.BåtHusetBokning.AddRange(båtHusetBokning);
            _context.SaveChanges();
        }
        private static void SeedAndraaktiviteterData()
        {
            List<OtherActivities> andraAktiviteter = new List<OtherActivities>();
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Barn-Activities", Price = 450, ActivitiesTime = "10am-12pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Spa-Center", Price = 1000, ActivitiesTime = "14pm-15pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Fish Pedicure and Manicure", Price = 1500, ActivitiesTime = "15pm-16pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Dance Show", Price = 750, ActivitiesTime = "16pm-17pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Singing Concert", Price = 1200, ActivitiesTime = "18pm-19pm" });


            _context.Andraaktiviteter.AddRange(andraAktiviteter);
            _context.SaveChanges();
        }

        private static void SeedBåtHusetBokningTransactionData()
        {
            List<BåtHusetBokningTransaction> båtHusetBokningTransaction = new List<BåtHusetBokningTransaction>();
            båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { UserId = 15, DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Barn-Activities", Restaurant = "Non-Vegeterian Food(200Kr)", NoOfPersons = 2, Beverages = "Water bottle",TotalPrice=2230 });
            _context.BåtHusetBokningTransaction.AddRange(båtHusetBokningTransaction);
            _context.SaveChanges();

            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Spa-Center", Restaurant = "Vegeterian Food(150Kr)", PriceOfTicket = 1000, Beverages = "Beer" });
            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Fish Pedicure and Manicure", Restaurant = "Non-Vegeterian Starters(100kr)", PriceOfTicket = 1500, Beverages = "Coffee" });
            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Dance Show", Restaurant = " Vegeterian Starters(190kr)", PriceOfTicket = 750, Beverages = "Cold drinks" });
            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Singing Concert", Restaurant = " ", PriceOfTicket = 1200, Beverages = "Wine" });
            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Magic Show", Restaurant = " ", PriceOfTicket = 600, Beverages = "Tea" });



        }

    }
}
