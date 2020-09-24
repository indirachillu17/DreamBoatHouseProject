using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages
{
    public class BåtHusetBokningModel : PageModel
    {
        public string DiscoverBoatHouse { get; set; }

        public void OnGet()
        {
            DiscoverBoatHouse = HttpContext.Session.GetString("discoverBoatHouse");
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("discoverBoatHouse");
            return RedirectToPage("Index");
        }
    }
}