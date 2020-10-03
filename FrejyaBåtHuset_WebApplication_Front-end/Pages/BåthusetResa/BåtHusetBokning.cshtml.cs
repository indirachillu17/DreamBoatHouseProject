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

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class BåtHusetBokningModel : PageModel
    {

        private ApiHelper apiHelper = new ApiHelper();

        [BindProperty]
        public IList<BåtHusetBokning> båtHusetBokning { get; set; }

        [BindProperty]
        public List<string> areChecked{ get; set; }

        [BindProperty]
        public List<string> lstBeverages { get; set; }


        [BindProperty]
        public List<string> lstRestaurant { get; set; }

        [BindProperty]
        public BåtHusetBokning båtHusetBokningSave { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();


            }

            string otherActivities = string.Empty;
            foreach(var item in areChecked)
            {
                //item.value = "Barn ACtivities";
                if (!string.IsNullOrEmpty(otherActivities))
                    otherActivities += ",";

                otherActivities += item;
            }

            string restaurant = string.Empty;
            foreach (var item1 in lstRestaurant)
            {
                //item.value = "Barn ACtivities";
                if (!string.IsNullOrEmpty(restaurant))
                    restaurant += ",";

                restaurant += item1;
            }
            string beverages = string.Empty;
            foreach (var item1 in lstBeverages)
            {
                //item.value = "Barn ACtivities";
                if (!string.IsNullOrEmpty(beverages))
                    beverages += ",";

                beverages += item1;
            }


           

            båtHusetBokningSave = båtHusetBokning.FirstOrDefault();
            båtHusetBokningSave.OtherActivities = otherActivities;
            båtHusetBokningSave.Restaurant = restaurant;
            båtHusetBokningSave.Beverages = beverages;
            



            //båtHusetBokningSave = båtHusetBokning.FirstOrDefault();
            //båtHusetBokningSave.Restaurant = lstRestaurant;

            var a = await apiHelper.PostCallApiAsync<BåtHusetBokning>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction", båtHusetBokningSave);

            return RedirectToPage("./BåtHusetBokning");

        }
        public async Task OnGet(int id)

        {
            //båtHusetBokning = await apiHelper.GetCallApiAsync<BåtHusetBokning>(GlobalValue.ApiPath + "/BåtHusetBokning/" +id);
            båtHusetBokning = await apiHelper.GetCallApiAsync<IList<BåtHusetBokning>>(GlobalValue.ApiPath + "/BåtHusetBokning");
            //båtHusetBokningSave = await apiHelper.GetCallApiAsync<BåtHusetBokning>(GlobalValue.ApiPath + "/BåtHusetBokning");

            //foreach(var item in båtHusetBokning)
            //{
            //    SelectListItem selectList = new SelectListItem()
            //    {
            //        Text =item.Restaurant,
            //        Value = item.Restaurant.ToString(),
            //        //Selected = item.Restaurant
            //    };
            //    båtHusetBokning.Add(selectList);
            //}

           
        }

        

        
    }

}
