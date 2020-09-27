using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using FrejyaBåtHuset_WebAPI_Backend.Models;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.UserDetails
{
    public class UserDetailsListModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();


        [BindProperty]
        public IList<User> listofusers { get; set; }
        public async Task OnGet()
        {
                
            listofusers = await apiHelper.GetCallApiAsync<IList<User>>(GlobalValue.ApiPath + "/user");
        }


    }
}