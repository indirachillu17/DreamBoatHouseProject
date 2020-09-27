using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }
        

        private static void SeedUsersData()
        {
            List<User> users = new List<User>();
            users.Add(new User() { EmailId = "abc@ab.com", Password = "abc", UserName = "abc", UserType = "user" });
            users.Add(new User() { EmailId = "nayana@ab.com", Password = "nayana", UserName = "nayana", UserType = "admin" });

            _context.Users.AddRange(users);
            _context.SaveChanges();
        }
        
    }
}
