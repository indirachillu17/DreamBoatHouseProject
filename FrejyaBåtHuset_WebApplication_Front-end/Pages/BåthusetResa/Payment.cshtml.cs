using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class PaymentModel : PageModel
    {
        [BindProperty]
        public Payment payment { get; set; }
        [BindProperty]
        public BåtHusetBokningTransaction båtHusetBokningSummary { get; set; }
        private ApiHelper apiHelper = new ApiHelper();

        public async Task OnGet(int id)
        {
            
            båtHusetBokningSummary = await apiHelper.GetCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction/" + id);
        }

        public async Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
            {
                båtHusetBokningSummary = await apiHelper.GetCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction/" + båtHusetBokningSummary.BåtHusetBokningTransactionID);

                return Page();
            }

            return RedirectToPage("/BåthusetResa/PaymentSummary", new { id= båtHusetBokningSummary.BåtHusetBokningTransactionID });
        }
    }
}