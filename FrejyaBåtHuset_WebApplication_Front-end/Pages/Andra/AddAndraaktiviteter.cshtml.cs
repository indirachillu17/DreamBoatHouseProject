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
    public class AddAndraaktiviteterModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();
        [BindProperty]
        public Andraaktiviteter newotheractivities{ get; set; }
        public void OnGet()
        {
            newotheractivities = new Andraaktiviteter();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            var b = await apiHelper.PostCallApiAsync<Andraaktiviteter>(GlobalValue.ApiPath + "/Andraaktiviteter", newotheractivities);

            return RedirectToPage("./AndraaktiviteterList");

        }


    }
}