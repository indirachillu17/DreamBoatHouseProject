using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class BåtHusetBokningModel : PageModel
    {

        private ApiHelper apiHelper = new ApiHelper();

        [BindProperty]
        public BåtHusetBokning båtHusetBokning { get; set; }
        [BindProperty]
        public IList<BåtHusetBokning> listofusers { get; set; }

        public async Task OnGet(int id)
        {
            //båtHusetBokning = await apiHelper.GetCallApiAsync<BåtHusetBokning>(GlobalValue.ApiPath + "/BåtHusetBokning/" +id);
            listofusers = await apiHelper.GetCallApiAsync<IList<BåtHusetBokning>>(GlobalValue.ApiPath + "/BåtHusetBokning" );

        }
    }
}