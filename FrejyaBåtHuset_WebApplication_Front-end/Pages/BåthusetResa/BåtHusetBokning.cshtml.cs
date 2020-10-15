using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLitePCL;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Namotion.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class BåtHusetBokningModel : PageModel
    {

        private ApiHelper apiHelper = new ApiHelper();

        [BindProperty]
        public IList<BåtHusetBokning> båtHusetBokning { get; set; }

        [BindProperty]
        public List<string> areChecked { get; set; }


        //[BindProperty]
        //public string OnClick { get; set; }


        [BindProperty]
        public decimal priceOfRestaurant { get; set; }

        [BindProperty]
        public decimal priceOfActivity { get; set; }
        [BindProperty]
        public decimal TotalPrice { get; set; }


        [BindProperty]
        public List<string> lstBeverages { get; set; }

        [BindProperty]
        public int NoOfPersons { get; set; }

        //[BindProperty]

        //public BåtHusetBokningTransaction båtHusetBokningTransaction { get; set; }

        [BindProperty]
        public List<string> lstRestaurant { get; set; }

        //[BindProperty]
        //public BåtHusetBokning båtHusetBokningSave { get; set; }

        [BindProperty]
        public BåtHusetBokningTransaction båtHusetBokningTransaction { get; set; }

        //båtHusetBokningTransaction = new BåtHusetBokningTransaction();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }

            //decimal price = 0;
            string otherActivities = string.Empty;
            decimal priceOfActivity = 0;

            foreach (var item in areChecked)
            {
                //item.value = "Barn ACtivities";
                if (!string.IsNullOrEmpty(otherActivities))
                    otherActivities += ",";

                otherActivities += item;
                String[] result = Regex.Split(otherActivities, " ");
                int length = result.Count();
                priceOfActivity += Convert.ToDecimal(result[length - 1]);

            }

            ////andraaktiviteter.Where(p=>p.ActivityName.Contains(item));
            // var found = båtHusetBokning.Where(p => p.OtherActivities == otherActivities).Single();
            //if(found.PriceOfTicket.Equals(1000) ||found.PriceOfTicket.Equals(450))
            // {
            //     Console.WriteLine(found); 
            // }
            ////var result= andraaktiviteter.Where(p =>p.ActivityName.Contains());
            //}
            //decimal price =0;
            //string otherActivities = string.Empty
            //foreach(var item in areChecked)
            //{
            //    //item.value = "Barn ACtivities";
            //    if (!string.IsNullOrEmpty(otherActivities))
            //        otherActivities += ",";

            //    otherActivities += item;
            //    //price += båtHusetBokning[0].PriceOfTicket;
            //}

            string restaurant = string.Empty;
            decimal priceOfRestaurant = 0;

            foreach (var item1 in lstRestaurant)
            {
                //item.value = "Barn ACtivities";
                if (!string.IsNullOrEmpty(restaurant))
                    restaurant += ",";

                restaurant += item1;
                String[] result = Regex.Split(restaurant, " ");
                int length = result.Count();
                priceOfRestaurant += Convert.ToDecimal(result[length - 1]);
                //    return totalPrice1.ToString();
            }
            string beverages = string.Empty;
            foreach (var item1 in lstBeverages)
            {

                //item.value = "Barn ACtivities";
                if (!string.IsNullOrEmpty(beverages))
                    beverages += ",";

                beverages += item1;
            }

            båtHusetBokningTransaction = BindData(otherActivities, restaurant, beverages);
            TotalPrice = ((350 + priceOfActivity + priceOfRestaurant) * NoOfPersons);
            var userId = HttpContext.Session.GetString("Id");
            båtHusetBokningTransaction.UserId = Convert.ToInt32(userId);
            båtHusetBokningTransaction.TotalPrice = TotalPrice;
            //båtHusetBokningTransaction.UserId = userDetails.Id;
            //{
            //   
            //}
            //if (userDetails.EmailId == "indiravinoth17@gmail.com" && userDetails.Password == "indira)
            ////string Message;
            var a = await apiHelper.PostCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction", båtHusetBokningTransaction);
            
            return RedirectToPage("./BåtHusetbokningSummary");
            //return RedirectToPage("./BåtHusetBokning");
            //HttpContext.Session.SetString("Name", userDetails.UserName);
            //HttpContext.Session.SetString("Role", userDetails.UserType);
            //return RedirectToPage("./BåtHusetBokning");
        }

        private BåtHusetBokningTransaction BindData(string otherActivities, string restaurant, string beverages)
        {
            båtHusetBokningTransaction.DiscoverBoatHouse = båtHusetBokning[0].DiscoverBoatHouse;
            båtHusetBokningTransaction.BoatTripPrice = båtHusetBokning[0].BoatTripPrice;
            båtHusetBokningTransaction.BoatStartTime = båtHusetBokning[0].BoatStartTime;
            båtHusetBokningTransaction.BoatEndTime = båtHusetBokning[0].BoatEndTime;
            båtHusetBokningTransaction.BoatTripDate = båtHusetBokning[0].BoatTripDate;

            båtHusetBokningTransaction.OtherActivities = otherActivities;
            båtHusetBokningTransaction.Restaurant = restaurant;
            båtHusetBokningTransaction.Beverages = beverages;
            båtHusetBokningTransaction.NoOfPersons = NoOfPersons;
            //if(båtHusetBokningTransaction.NoOfPersons > 50)
            //{

            //    Console.WriteLine("Maximium 50 persons is allowed");
                
            //}
            //båtHusetBokningTransaction.TotalPrice = TotalCost;
            return båtHusetBokningTransaction;
        }

        public async Task OnGet(int id)

        {
           
            båtHusetBokning = await apiHelper.GetCallApiAsync<IList<BåtHusetBokning>>(GlobalValue.ApiPath + "/BåtHusetBokning");
        }


        
    }

}

    

