using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using Microsoft.AspNetCore.Http;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.Login
{
    public class LoginModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();


        public string Message { get; set; }

        [BindProperty]

        public User login { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await apiHelper.PostCallApiAsync<User>(GlobalValue.ApiPath + "/user/IsValidUser", login);

            if (user != null)
            {
                HttpContext.Session.SetString("Id", user.Id.ToString());
                HttpContext.Session.SetString("Name", user.UserName);
                HttpContext.Session.SetString("Role", user.UserType);

                if (user.UserType.ToLower() == "admin")
                    return RedirectToPage("/Andra/AndraaktiviteterList");
                else
                    return RedirectToPage("/BåthusetResa/BåtHusetBokning");


            }
            else
            {
                Message = "Either username or password invalid.";
                return Page();
            }

        }

        
















        }

    }



