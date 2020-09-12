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
        

        // User methods

        [HttpGet]
        [Route("Users")]
        public IActionResult Users(string id)
        {


            var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService = "/users";
            if (id!=null && id!="")
            {
                UrlService += "?id=" + id;
            }
            var Data = new List<User> { };
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Urlbase);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync(UrlService).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject<List<User>>(stringJWT);

            }
            catch
            {


            }

            return Ok(Data);
        }




        


        // User albums

        [HttpGet]
        [Route("albums")]
        public IActionResult albums(string id)
        {


            var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService = "/albums";
            if (id != null && id != "")
            {
                UrlService += "?id=" + id;
            }
            var Data = new List<Album> { };
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Urlbase);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync(UrlService).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject<List<Album>>(stringJWT);

            }
            catch
            {


            }

            return Ok(Data);
        }


        //Photo Methods

        [HttpGet]
        [Route("Photos")]
        public IActionResult Photos(string id)
        {


            var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService = "/albums/1/photos";
            if (id != null && id != "")
            {
                UrlService += "?id=" + id;
            }
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


       


        [Route("PhotoRegister")]
        [HttpPost]
        public IActionResult PhotoRegister(Photo Data)
        {


            var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService = "/albums/1/photos";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Urlbase);
            try
            {
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                string stringData = JsonConvert.SerializeObject(Data);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(UrlService, contentData).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject<Photo>(stringJWT);

            }
            catch
            {

            }
            return Ok(Data);
        }


        [Route("PhotoUpdate")]
        [HttpPut]
        public IActionResult PhotoUpdate(Photo Data)
        {


            var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService = "/albums/1/photos";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Urlbase);
            try
            {
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                string stringData = JsonConvert.SerializeObject(Data);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync(UrlService, contentData).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject<Photo>(stringJWT);

            }
            catch
            {

            }
            return Ok(Data);
        }


        [Route("PhotoDelete")]
        [HttpDelete]
        public IActionResult PhotoDelete(string id)
        {


            var Urlbase = "https://jsonplaceholder.typicode.com";
            var UrlService = "/albums/1/photos";
            var Resultado = "";
            if (id != null && id != "")
            {
                UrlService += "?id=" + id;
            }
            var Data = new List<Photo> { };
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Urlbase);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.DeleteAsync(UrlService).Result;
                string stringJWT = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject<List<Photo>>(stringJWT);

            }
            catch
            {


            }
        
            return Ok(Resultado);
        }





    }
}