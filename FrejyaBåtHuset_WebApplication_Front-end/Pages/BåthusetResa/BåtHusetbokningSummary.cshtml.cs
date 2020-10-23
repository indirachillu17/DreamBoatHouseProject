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
        //[BindProperty]
        //public List<int> Submit { get; set; }


        [BindProperty]
        public BåtHusetBokningTransaction booking { get; set; }
        public async Task OnGet(int? id)
        {
            //Submit = new List<int>();
            
            båtHusetBokningSummary = new List<BåtHusetBokningTransaction>();
            booking = new BåtHusetBokningTransaction();
            //båtHusetBokningSummary = await apiHelper.GetCallApiAsync<IList<BåtHusetBokningTransaction>>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction/"+id);
            booking = await apiHelper.GetCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction/" + id);
            //RedirectToPage("/BåthusetResa/payment", new { id = booking.BåtHusetBokningTransactionID });

        }
        
        //public  object SubmitPage()
        //{
        //   //return RedirectToPage("/BåthusetResa/payment", new { id = booking.BåtHusetBokningTransactionID });
        //    return RedirectToPage("./payment", new { id = booking.BåtHusetBokningTransactionID });
        //}

        //public async Task<IActionResult> OnGetAsync(int id)
        //{
        ////    if (booking.BåtHusetBokningTransactionID == 0)
        ////    {
        ////        booking = await apiHelper.GetCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction/" + id);
        ////        return RedirectToPage("/BåthusetResa/payment", new { id = booking.BåtHusetBokningTransactionID });
        ////    }
        ////    else
        ////    {
        ////        return RedirectToPage("/BåthusetResa/payment", new { id = booking.BåtHusetBokningTransactionID });
        ////    }
        ////}
        ////RedirectToPage("/BåthusetResa/payment", new { id = booking.BåtHusetBokningTransactionID});
        //}
        //public async Task<IActionResult> OnPostAsync()
        //{

        //    //booking = await apiHelper.PostCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction", booking);

        //    //return RedirectToPage("/BåthusetResa/payment", new { id = booking.BåtHusetBokningTransactionID });
        //    //    if (!ModelState.IsValid)
        //    //    {
        //    //        booking = new BåtHusetBokningTransaction();
        //    //        booking= await apiHelper.GetCallApiAsync<BåtHusetBokningTransaction>(GlobalValue.ApiPath + "/BåtHusetBokningTransaction/"+booking.BåtHusetBokningTransactionID);
        //    //        return RedirectToPage("/BåthusetResa/payment", booking);
        //    //}

    }
}
