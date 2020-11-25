using System;
using Xunit;
using FrejyaBåtHuset_WebAPI_Backend.Controllers;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using System.Linq;
using FluentAssertions;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using FrejyaBåtHuset_WebAPI_Backend;
using System.Text;

namespace BoatHouseUnitTestingProject
{
   public class BåtHusetUnitTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        public HttpClient client { get; }
        
       

        public BåtHusetUnitTest(WebApplicationFactory<Startup> fixture)
        {
            client = fixture.CreateClient();
        }

        [Fact]
        public async Task Post_BåtHusetBokning()
        {
            BåtHusetBokning båtHusetBokning = new BåtHusetBokning { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Clay Moulding", ActivitiesTiming = "12-1pm", Restaurant = "Non-Vegeterian Food 200", PriceOfTicket = 600, Beverages = "Water bottle" };
            //BåtHusetBokning båtHusetBokning = new BåtHusetBokning { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Clay moulding ", ActivitiesTiming = "12-1pm", Restaurant = "Non-Vegeterian Food 200", PriceOfTicket = 600, Beverages = "Water bottle" };
            var json = JsonConvert.SerializeObject(båtHusetBokning);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var client = new HttpClient();

            var response = await client.PostAsync("https://localhost:44378/api/BåtHusetBokning", stringContent);
            response.StatusCode.Should().Be(HttpStatusCode.Created);


        }

        [Fact]
        public async Task Get_BåtHusetBokning()
        {
            var response = await client.GetAsync("https://localhost:44378/api/BåtHusetBokning/");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            //var båtHusetBokningsDetails = JsonConvert.DeserializeObject<BåtHusetBokning[]>(await response.Content.ReadAsStringAsync());
            //båtHusetBokningsDetails.Should().HaveCount();

        }


        
    }
}
