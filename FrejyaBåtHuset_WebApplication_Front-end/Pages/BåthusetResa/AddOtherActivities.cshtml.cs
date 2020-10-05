using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using FrejyaBåtHuset_WebAPI_Backend.Models;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class AddOtherActivitiesModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();
        [BindProperty]
        public OtherActivities newotheractivities{ get; set; }
        public void OnGet()
        {
            newotheractivities = new OtherActivities();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            var b = await apiHelper.PostCallApiAsync<OtherActivities>(GlobalValue.ApiPath + "/Andraaktiviteters", newotheractivities);

            return RedirectToPage("./OtherActivitiesList");

        }


    }
}