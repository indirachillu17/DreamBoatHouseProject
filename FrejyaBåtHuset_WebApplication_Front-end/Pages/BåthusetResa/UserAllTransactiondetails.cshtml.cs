using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class UserAllTransactiondetailsModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();
        [BindProperty]
        public IList<BåtHusetBokningTransaction> båtHusetBokningSummary { get; set; }
        public async Task OnGet()
        {
            var userId = Convert.ToInt32(HttpContext.Session.GetString("Id"));
            //båtHusetBokningTransaction.UserId = Convert.ToInt32(userId);
            båtHusetBokningSummary = new List<BåtHusetBokningTransaction>();
            båtHusetBokningSummary = await apiHelper.GetCallApiAsync<List<BåtHusetBokningTransaction>>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction" );
            båtHusetBokningSummary=båtHusetBokningSummary.Where(s => s.UserId == userId).ToList();
        }
    }
}