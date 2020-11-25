using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FrejyaBåtHuset_WebAPI_Backend.Controllers;
using FrejyaBåtHuset_WebAPI_Backend.Models;
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



namespace BoatHouseUnitTestingProject
{
    public class LoginUnitTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        public HttpClient client { get; }
        int UserId;


        public LoginUnitTest(WebApplicationFactory<Startup> fixture)
        {
            client = fixture.CreateClient();
        }

        [Fact]
        public async Task IfUserIsValid()
        {
            User login = new User { Id = 2, UserName = "nayana", EmailId = "nayana@ab.com", Password = "nayana", UserType = "admin" };
            var json = JsonConvert.SerializeObject(login);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var client = new HttpClient();

            var response = await client.PostAsync("https://localhost:44378/api/User/IsValidUser", stringContent);
            response.StatusCode.Should().Be(HttpStatusCode.Accepted);
        }

        [Fact]
        public async Task IfUserIsInValid()
        {
            User login = new User { Id = 2, UserName = "nayana", EmailId = "nayana@ab.com", Password = "nayana1", UserType = "admin" };
            var json = JsonConvert.SerializeObject(login);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var client = new HttpClient();

            var response = await client.PostAsync("https://localhost:44378/api/User/IsValidUser", stringContent);
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }


        [Fact]

        public async Task AddNewUser()
        {
            User login = new User { UserName = "Test1", EmailId = "test1@ab.com", Password = "test", UserType = "user" };
            var json = JsonConvert.SerializeObject(login);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var client = new HttpClient();

            var response = await client.PostAsync("https://localhost:44378/api/user", stringContent);
            var response1 = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(response1))
            { 
                UserId = JsonConvert.DeserializeObject<User>(response1).Id;
            }
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task EditUser()
        {
            await AddNewUser();
            User login = new User { Id = UserId, UserName = "Test12", EmailId = "test1@ab.com", Password = "test", UserType = "user" };
            var json = JsonConvert.SerializeObject(login);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var client = new HttpClient();

            await client.PutAsync("https://localhost:44378/api/User/"+ UserId, stringContent);

            var user = await client.GetAsync("https://localhost:44378/api/User/" + UserId);
            var u = await user.Content.ReadAsStringAsync();
            User NewDetails=null;
            if (!string.IsNullOrEmpty(u))
            {
                NewDetails = JsonConvert.DeserializeObject<User>(u);
            }

            NewDetails.UserName.Should().Be(login.UserName);
        }
    }
}

