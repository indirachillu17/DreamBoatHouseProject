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
    public class EditAndraaktiviteterModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();

        [BindProperty]
        public Andraaktiviteter editotheractivities { get; set; }
        public async Task OnGet(int id)
        {
            editotheractivities = await apiHelper.GetCallApiAsync<Andraaktiviteter>(GlobalValue.ApiPath + "/Andraaktiviteter/" + id);
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            await apiHelper.PutCallApiAsync<Andraaktiviteter>(GlobalValue.ApiPath + "/Andraaktiviteter/" + id,editotheractivities);

            return RedirectToPage("./AndraaktiviteterList");
        }
    }
}