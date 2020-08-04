using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pension_Management_Portal.Models;

namespace Pension_Management_Portal.Controllers
{
    public class HomeController : Controller
    {
       static string token;
        PensionDetail pen = new PensionDetail();
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
             token = GetToken("http://localhost:53093/api/Token", user);
            if (token != null)
            {
                return RedirectToAction("Index", "PensionerValues", new { name = token });
            }
            else
            {
                ViewBag.invalid = "UserName or Password invalid";
                return View();
            }
        }
        static string GetToken(string url, User user)
        {

            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, data).Result;
                string name = response.Content.ReadAsStringAsync().Result;
                dynamic details = JObject.Parse(name);
                return details.token;
            }
        }

        [HttpGet]
        public IActionResult PensionerValues()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> PensionerValues(PensionerInput input)
        {
            if(ModelState.IsValid)
            {
                
                using (var client = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");

                    client.BaseAddress = new Uri("http://52.143.250.249/");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    using (var response = await client.GetAsync("https://localhost:44317/api/CustomerCareService/"+ content))    //Get Post Mai check kar lena
                    {

                        string apiResponse = await response.Content.ReadAsStringAsync();
                        pen = JsonConvert.DeserializeObject<PensionDetail>(apiResponse);
                    }
                }
                return RedirectToAction("PensionervaluesDisplayed");
            }
           
            else
            {
                ViewBag.invalid = "Pensioner Values are Invalid";
                return View();
            }
           
        }
        [HttpGet]
        public IActionResult PensionervaluesDisplayed()
        {
            return View(pen);
        }

       
    }
}
