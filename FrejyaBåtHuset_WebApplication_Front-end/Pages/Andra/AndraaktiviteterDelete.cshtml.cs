using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using FrejyaBåtHuset_WebAPI_Backend.Models;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages
{
    public class AndraaktiviteterDeleteModel : PageModel
    {
            private ApiHelper apiHelper = new ApiHelper();

            [BindProperty]
            public Andraaktiviteter otheractivitiesdetails { get; set; }
            public async Task OnGet(int id)
            {
                otheractivitiesdetails = await apiHelper.GetCallApiAsync<Andraaktiviteter>(GlobalValue.ApiPath + "/Andraaktiviteter/" + id);

            }

            public async Task<IActionResult> OnPostAsync(int id)
            {
                if (!ModelState.IsValid)
                {
                    return Page();

                }
                await apiHelper.DeleteCallApiAsync<Andraaktiviteter>(GlobalValue.ApiPath + "/Andraaktiviteter/" + id);

                return RedirectToPage("./AndraaktiviteterList");
            }
    }
    }

   