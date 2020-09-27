using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.AspNetCore.Http;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.UserDetails
{
    public class CreateUserModel : PageModel
    {
      
        private ApiHelper apiHelper = new ApiHelper();
       
        [BindProperty]
        public User myuser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }

            myuser.UserType = "user";
            var a= await apiHelper.PostCallApiAsync<User>(GlobalValue.ApiPath + "/user", myuser);

            return RedirectToPage("./UserDetailsList");

        }
        public void  OnGet()
        {
            myuser = new User();
            //if user is not admin then it will give invalid request & gives access only to admin
            //if (HttpContext.Session.GetString("Role") == "admin")

            //else
            //    throw new Exception("Invalid request");
        }
    }
}