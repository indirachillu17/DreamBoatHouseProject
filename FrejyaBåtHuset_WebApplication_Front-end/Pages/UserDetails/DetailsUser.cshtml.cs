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
    public class DetailsUserModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();

        [BindProperty]
        public User userdetails{ get; set; }


        public async Task OnGet(int id)
        {
            userdetails = await apiHelper.GetCallApiAsync<User>(GlobalValue.ApiPath + "/user/" + id);

            
        }
    }
}