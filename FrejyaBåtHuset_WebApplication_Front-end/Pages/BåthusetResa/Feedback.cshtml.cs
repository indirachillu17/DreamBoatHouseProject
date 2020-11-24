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
    public class FeedbackModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();
        [BindProperty]
        public List<string> experience { get; set; }

        [BindProperty]
        public string experience1 { get; set; }
        [BindProperty]
        public string comments { get; set; }
        [BindProperty]
        public int UserId { get; set; }
        //[BindProperty]
        //public string message { get; set; }
        [BindProperty]
        public FeedBack feedBack { get; set; }
       
        public async Task<ActionResult> OnPostAsync()
        {
            feedBack = new FeedBack();
            var userId = Convert.ToInt32(HttpContext.Session.GetString("Id"));
            feedBack.UserId =userId;
            //var userId = HttpContext.Session.GetString("Id");
            //feedBack.UserId= Convert.ToInt32(userId);
            feedBack.OverallExperience = experience[0].ToString();
            feedBack.BestExperience = experience1;
            feedBack.AnyAdditionalComments = comments.Trim();

          var feedBackDetails = await apiHelper.PostCallApiAsync<FeedBack>(GlobalValue.ApiPath + "/FeedBack",feedBack);
            //message = "The feeback is updated successfully.Do you want to goback to homepage";
            return RedirectToPage("/Index");
            //return RedirectToPage("./BåtHusetbokningSummary", feedBackDetails);
            //return feedBackDetails;
        }
    }
}