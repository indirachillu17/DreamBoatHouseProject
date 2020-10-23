

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

            if (_context.FeedBack.Count() <= 0)
            {
                SeedFeedBack();
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
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse=1 ,BoatTripPrice=350, BoatTripDate=Convert.ToDateTime("2020-12-23"), BoatStartTime=" 10:00:00" ,BoatEndTime = " 19:00:00",OtherActivities="Barn-Activities ", ActivitiesTiming = "10am-12pm",Restaurant ="Non-Vegeterian Food 200", PriceOfTicket = 600,Beverages="Water bottle" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00",  OtherActivities = "Spa-Center", ActivitiesTiming = "1pm-2pm", Restaurant = "Vegeterian Food 150", PriceOfTicket = 1000, Beverages = "Beer"});
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00",  OtherActivities = "Fish Pedicure and Manicure", ActivitiesTiming = "2pm-3pm", Restaurant = "Non-Vegeterian Starters 100", PriceOfTicket = 1800,Beverages= "Coffee"});
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00",  OtherActivities = "Dance Show", ActivitiesTiming = "3pm-4pm",Restaurant = " Vegeterian Starters 190", PriceOfTicket = 750, Beverages = "Cold drinks"});
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Singing Concert", ActivitiesTiming = "4pm-5pm", Restaurant = " ", PriceOfTicket = 1200 , Beverages = "Wine"});
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Magic Show", ActivitiesTiming = "5pm-6pm", Restaurant = " ", PriceOfTicket = 1500 ,Beverages="Tea"});
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Chess", ActivitiesTiming = "6pm-7pm", Restaurant = " ", PriceOfTicket = 450, Beverages = "Vodka"});


            _context.BåtHusetBokning.AddRange(båtHusetBokning);
            _context.SaveChanges();
        }
        private static void SeedAndraaktiviteterData()
        {
            List<Andraaktiviteter> andraAktiviteter = new List<Andraaktiviteter>();
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Chess", Price = 450, ActivityTime = "6pm-7pm" });
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Magic Show", Price = 1500, ActivityTime = "5pm-6pm" });
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Singing Concert", Price = 1200, ActivityTime = "4pm-5pm" });
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Dance Show", Price = 750, ActivityTime = "3pm-4pm" });
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Fish Pedicure and Manicure", Price = 1800, ActivityTime = "2pm-3pm" });
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Spa-Center", Price = 1000, ActivityTime = "1pm-2pm " });
            andraAktiviteter.Add(new Andraaktiviteter() { ActivityName = "Barn-Activities", Price = 600, ActivityTime = "10am-12pm" });

            _context.Andraaktiviteter.AddRange(andraAktiviteter);
            _context.SaveChanges();
        }

        private static void SeedBåtHusetBokningTransactionData()
        {
            List<BåtHusetBokningTransaction> båtHusetBokningTransaction = new List<BåtHusetBokningTransaction>();
            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { UserId =0, DiscoverBoatHouse=0 , BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Barn-Activities", Restaurant = "Non-Vegeterian Food(200Kr)", NoOfPersons = 2, Beverages = "Water bottle", TotalPrice = 2230 });
            _context.BåtHusetBokningTransaction.AddRange(båtHusetBokningTransaction);
            _context.SaveChanges();




        }
        private static void SeedFeedBack()
        {
            List<FeedBack> feedBack = new List<FeedBack>();
            _context.FeedBack.AddRange(feedBack);
            _context.SaveChanges();
            //båtHusetBokningTransaction.Add(new BåtHusetBokningTransaction() { UserId =0, DiscoverBoatHouse=0 , BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Barn-Activities", Restaurant = "Non-Vegeterian Food(200Kr)", NoOfPersons = 2, Beverages = "Water bottle", TotalPrice = 2230 });





        }

    }
}
