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
            båtHusetBokning.Add(new BåtHusetBokning() { DiscoverBoatHouse=1 , BoatStart=Convert.ToDateTime("2020-12-23 10:00:00") ,BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"),ActivitiesTiming="10am-12pm",OtherActivities="Barn-Activities",Restaurant="Non-Vegeterian Food"});
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"), ActivitiesTiming = "14pm-15pm", OtherActivities = "Spa-Center", Restaurant = "Vegeterian Food" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"), ActivitiesTiming = "15pm-16pm", OtherActivities = "Fish Pedicure and Manicure", Restaurant = "Non-Vegeterian Food" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"), ActivitiesTiming = "16pm-17pm", OtherActivities = "Dance Show", Restaurant = "Vegeterian Food" });
            båtHusetBokning.Add(new BåtHusetBokning() {  DiscoverBoatHouse = 1, BoatStart = Convert.ToDateTime("2020-12-23 10:00:00"), BoatEnd = Convert.ToDateTime("2020-12-23 19:00:00"), ActivitiesTiming = "18pm-19pm", OtherActivities = "Singing Concert", Restaurant = " Non-Vegeterian and Vegeterian Starters" });
            

            _context.BåtHusetBokning.AddRange(båtHusetBokning);
            _context.SaveChanges();
        }
        private static void SeedAndraaktiviteterData()
        {
            List<Andraaktiviteter> andraAktiviteter = new List<Andraaktiviteter>();
            andraAktiviteter.Add(new Andraaktiviteter() {OtherActivities = "Barn-Activities", Price=450, NumberOfPersons= "5" });
            andraAktiviteter.Add(new Andraaktiviteter() {OtherActivities = "Spa-Center", Price=1000,NumberOfPersons="10" });
            andraAktiviteter.Add(new Andraaktiviteter() {OtherActivities = "Fish Pedicure and Manicure", Price=1500,NumberOfPersons="7"});
            andraAktiviteter.Add(new Andraaktiviteter() {OtherActivities = "Dance Show", Price=750,NumberOfPersons="12" });
            andraAktiviteter.Add(new Andraaktiviteter() {OtherActivities = "Singing Concert", Price=1200,NumberOfPersons="15" });

            _context.Andraaktiviteter.AddRange(andraAktiviteter);
            _context.SaveChanges();
        }


    }
}
