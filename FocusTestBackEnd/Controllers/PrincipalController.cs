using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using FocusTestBackEnd.Models;

namespace FocusTestBackEnd.Controllers
{
    [Route("FocusTest/[controller]")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        [HttpGet]
        [Route("Photos")]
        public IActionResult Photos()
        {


           var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService =  "/albums/1/photos";
            var Data = new List<Photo> { };
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Urlbase);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync(UrlService).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject<List<Photo>>(stringJWT);
                
            }
            catch
            {

               
            }

            return Ok(Data);
        }

    }
}