using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.EntityFrameworkCore;
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
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse=1 , BoatStart=Convert.ToDateTime("2020-12-23 10:00:00") ,BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"),OtherActivities="Barn-Activities",Restaurant="Non-Vegeterian Food", PriceOfTicket = 450, NoOfPersons=2  });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"),  OtherActivities = "Spa-Center", Restaurant = "Vegeterian Food", PriceOfTicket = 1000, NoOfPersons=3  });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"),  OtherActivities = "Fish Pedicure and Manicure", Restaurant = "Non-Vegeterian Starters", PriceOfTicket = 1500, NoOfPersons=4 });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"),  OtherActivities = "Dance Show", Restaurant = " Vegeterian Starters", PriceOfTicket = 750, NoOfPersons = 5 });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"), OtherActivities = "Singing Concert", Restaurant = " ", PriceOfTicket = 1200, NoOfPersons =6 });
            

            _context.BåtHusetBokning.AddRange(båtHusetBokning);
            _context.SaveChanges();
        }
        private static void SeedAndraaktiviteterData()
        {
            List<OtherActivities> andraAktiviteter = new List<OtherActivities>();
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Barn-Activities",Price=450, ActivitiesTime = "10am-12pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Spa-Center", Price = 1000, ActivitiesTime = "14pm-15pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Fish Pedicure and Manicure", Price = 1500, ActivitiesTime = "15pm-16pm"});
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Dance Show", Price=750, ActivitiesTime = "16pm-17pm" });
            andraAktiviteter.Add(new OtherActivities() { NameOfactivity = "Singing Concert", Price=1200, ActivitiesTime = "18pm-19pm"});

            _context.Andraaktiviteter.AddRange(andraAktiviteter);
            _context.SaveChanges();
        }


    }
}
