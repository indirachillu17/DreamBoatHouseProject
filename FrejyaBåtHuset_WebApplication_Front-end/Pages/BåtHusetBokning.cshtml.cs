using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using FrejyaBåtHuset_WebAPI_Backend.Data;
//using FrejyaBåtHuset_WebAPI_Backend.Models;
//using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
//using System.Net.Http;
//using System.Net.Http.Headers;



namespace FrejyaBåtHuset_WebApplication_Front_end.Pages
{
    public class BåtHusetBokningModel : PageModel
    {
        //public string DiscoverBoatHouse { get; set; }
        //public List<int> Integers;

        public void OnGet()
        {

            //DiscoverBoatHouse = HttpContext.Session.GetString("discoverBoatHouse");

            //Integers = new List<int>();
            //Integers.Add(1);
            //Integers.Add(2);
            //Integers.Add(3);
            //BåtHusetBokningModel båtHuset = new BåtHusetBokningModel();
            //var r = båtHuset.RunAsync();
            //Console.WriteLine(r);

        }
        //public IActionResult OnGetLogout()
        //{
        //    HttpContext.Session.Remove("discoverBoatHouse");
        //    return RedirectToPage("Index");

        //    //try
            //{
            //    HttpResponseMessage response = await client.GetAsync("api/BåtHusetBokning");
            //    resp.EnsureSuccessStatusCode();    // Throw if not a success code.

            //    // ...
            //}
            //catch (HttpRequestException e)
            //{
            //    // Handle exception.
            //}
        //}

        public async Task RunAsync()
        {


            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:5001/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            //    // New code:
            //    //HttpResponseMessage response = await client.GetAsync("api/BåtHusetBokning");
            //    //if (response.IsSuccessStatusCode)
            //    //{
            //    //    //BåtHusetBokning båtHuset = await response.Content.ReadAsStreamAsync();
            //    //    var båtHuset = await response.Content.ReadAsStreamAsync();
            //    //    //båtHuset.DiscoverBoatHouse = 1;

            //    //    //Product product = await response.Content.ReadAsAsync > Product > ();
            //    //    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
            //    //}

            //}

            //public IActionResult BåtHusetBpokningModelOnClick()
            //{
            //    Console.WriteLine("sds");
            //}
        }

        
    }
}
