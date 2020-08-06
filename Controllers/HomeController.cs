﻿using System;
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
        PensionDetail penDetailObj = new PensionDetail();
        private readonly DataContext _context;

        // Dependency Injection
        public HomeController(DataContext context)
        {
            _context = context;
        }
        // Redirection to login page
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
            token = GetToken("https://localhost:44394/api/token", user);
            if (token.Equals("abcd"))
            {
                ViewBag.loginerror = "Error Occured";
                return View();
            }
            if (token != null)
            {
                return RedirectToAction("PensionerValues");
            }
            else
            {
                ViewBag.invalid = "UserName or Password invalid";
                return View();
            }
        }
        static string GetToken(string url, User user)
        {
            string token = "abcd";
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.PostAsync(url, data).Result;
                    string name = response.Content.ReadAsStringAsync().Result;
                    dynamic details = JObject.Parse(name);
                    return details.token;
                }
            }
            catch(Exception e)
            {
                return token;
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

           // string status;

            if (ModelState.IsValid)
            {

                using (var client = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");

                    client.BaseAddress = new Uri("https://localhost:44394/");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    try
                    {
                        using (var response = await client.PostAsync("api/ProcessPension/GetClient", content))    //Get Post Mai check kar lena
                        {
                            //var response = await client.GetAsync("api/ProcessPension/");
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            penDetailObj = JsonConvert.DeserializeObject<PensionDetail>(apiResponse);

                        }
                    }
                    catch(Exception e)
                    {
                        penDetailObj = null;
                    }

                }

                //return RedirectToAction("PensionervaluesDisplayed",pen);

                
                if(penDetailObj==null)
                {
                    ViewBag.erroroccured = "Some Error Occured";
                    return View();
                }
                if(penDetailObj.status.Equals(20))
                {
                    ViewBag.erroroccured = "Some Error Occured";
                    return View();
                }
                if (penDetailObj.status.Equals(10))
                {
                    // ViewBag.invalid = "Pensioner Values are Invalid";
                    _context.pensionDetails.Add(penDetailObj);
                    _context.SaveChanges();
                    return RedirectToAction("PensionervaluesDisplayed", penDetailObj);
                }
                else
                {
                    ViewBag.notmatch = "Pensioner Values not match";
                    return View();
                }

            }

            else
            {
                ViewBag.invalid = "Pensioner Values are Invalid";
                return View();
            }

        }
        [HttpGet]
        public IActionResult PensionervaluesDisplayed(PensionDetail penObj)
        {
            
            return View(penObj);


        }
        [HttpGet]
        public IActionResult ErrorPage()
        {

            return View();

        }



    }
}
