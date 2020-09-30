using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class SaveTripDetailsModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();
        
        [BindProperty]
        public BåtHusetBokning båtHusetBokning1 { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }


            var a = await apiHelper.PostCallApiAsync<BåtHusetBokning>(GlobalValue.ApiPath + "/BåtHusetBokning", båtHusetBokning1);
            // change to be done -Report page to be shown to the user
            return RedirectToPage("./HomePage");

        }

        public void OnGet()
        {

        }
    }
}