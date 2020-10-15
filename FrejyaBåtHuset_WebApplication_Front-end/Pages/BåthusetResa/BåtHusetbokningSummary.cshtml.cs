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
    public class BåtHusetbokningSummaryModel : PageModel
    {

        private ApiHelper apiHelper = new ApiHelper();
        [BindProperty]

        public IList<BåtHusetBokningTransaction> båtHusetBokningSummary { get; set; }
        public async Task OnGet()
        {
            båtHusetBokningSummary = new List<BåtHusetBokningTransaction>();

            båtHusetBokningSummary = await apiHelper.GetCallApiAsync<IList<BåtHusetBokningTransaction>>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction");
        }



    }
}