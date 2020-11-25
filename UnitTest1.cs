using System;
using Xunit;
using FrejyaB�tHuset_WebAPI_Backend.Controllers;
using FrejyaB�tHuset_WebAPI_Backend.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using FrejyaB�tHuset_WebAPI_Backend.Data;
using System.Linq;
using FluentAssertions;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using FrejyaB�tHuset_WebAPI_Backend;
using System.Text;

namespace BoatHouseUnitTestingProject
{
  
        public class B�tHusetBokningControllerTests : IClassFixture<WebApplicationFactory<Startup>>
        {
            public HttpClient client { get; }

        public B�tHusetBokningControllerTests(WebApplicationFactory<Startup> fixture)
        {
            client = fixture.CreateClient();
        }


        [Fact]
        public async Task Post_B�tHusetBokning()
        {
            B�tHusetBokning b�tHusetBokning = new B�tHusetBokning { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Barn-Activities ", ActivitiesTiming = "10am-12pm", Restaurant = "Non-Vegeterian Food 200", PriceOfTicket = 600, Beverages = "Water bottle" };
            //B�tHusetBokning b�tHusetBokning = new B�tHusetBokning { DiscoverBoatHouse = 1, BoatTripPrice = 350, BoatTripDate = Convert.ToDateTime("2020-12-23"), BoatStartTime = " 10:00:00", BoatEndTime = " 19:00:00", OtherActivities = "Clay moulding ", ActivitiesTiming = "12-1pm", Restaurant = "Non-Vegeterian Food 200", PriceOfTicket = 600, Beverages = "Water bottle" };
            var json = JsonConvert.SerializeObject(b�tHusetBokning);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var client = new HttpClient();
            //var byteContent = new ByteArrayContent(b�tHusetBokning);
            var response = await client.PostAsync("http://localhost:44378/api/B�tHusetBokning/", stringContent);
            response.StatusCode.Should().Be(HttpStatusCode.Created);

        }




        //[Fact]
        //public async Task Get_B�tHusetBokning()
        //{
        //    var response = await client.GetAsync("http://localhost:44378/api/B�tHusetBokning/");
        //    response.StatusCode.Should().Be(HttpStatusCode.OK);

        //    //var b�tHusetBokningsDetails = JsonConvert.DeserializeObject<B�tHusetBokning[]>(await response.Content.ReadAsStringAsync());
        //    //b�tHusetBokningsDetails.Should().HaveCount();

        //}

       
    }
}

