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


            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment+ "/users";
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

        [Route("Users")]
        [HttpPost]
        public IActionResult UsersRegister(User Data)
        {

            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment + "/Users";


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
                Data = JsonConvert.DeserializeObject<User>(stringJWT);

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

            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment + "/albums";
           
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

            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment + "/photos";
          
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


       


        [Route("Photos")]
        [HttpPost]
        public IActionResult PhotoRegister(Photo Data)
        {

            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment + "/photos";

           
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


        [Route("Photos")]
        [HttpPut]
        public IActionResult PhotoUpdate(Photo Data)
        {


            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment + "/photos";

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


        [Route("Photos")]
        [HttpDelete]
        public IActionResult PhotoDelete(string id)
        {


            var Urlbase = "https://my-json-server.typicode.com/";
            var UrlSegment = "/jhlarios/dbjson";
            var UrlService = UrlSegment + "/photos";
       
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
        
            return Ok(Data);
        }

        // Custom Grid methods

        [HttpGet]
        [Route("UserGrid")]
        public IActionResult UserGrid(string name, string username, string email, string city)
        { 
            var Data = new List<UserGridModel> { };
            var Users = new List<User> { };
            var Albums = new List<Album> { };
            var Photos = new List<Photo> { };
            try
            {
                
                Users = JsonConvert.DeserializeObject<List<User>>(GetJson("users"));
                Albums = JsonConvert.DeserializeObject<List<Album>>(GetJson("albums"));
                Photos = JsonConvert.DeserializeObject<List<Photo>>(GetJson("photos"));
            }
            catch
            {
            }
             Data =
                 (from Usl  in Users
                  where (Usl.name.Contains((String.IsNullOrEmpty(name) ? Usl.name:name))
                  || Usl.username.Contains((String.IsNullOrEmpty(username) ? Usl.username : username))
                  || Usl.email.Contains((String.IsNullOrEmpty(email) ? Usl.email : email))
                  )
                  && Usl.address.city.Contains((String.IsNullOrEmpty(city) ? Usl.address.city : city))
                  select new UserGridModel
                 { 
                 id= Usl.id
                 ,name= Usl.name
                 ,username= Usl.username
                 ,email= Usl.email
                 ,address= Usl.address.street + ","+ Usl.address.suite + "," + Usl.address.city               
                  }).ToList();


            foreach (var item in Data)
            {
                var AlbumData = Albums.Where(x => x.userId == item.id);
                
                if (AlbumData.Count() > 0)
                { 
                    item.thumbnailUrl = Photos.Where(a=>a.albumId== AlbumData.FirstOrDefault().id).FirstOrDefault().thumbnailUrl ?? "" ;
                }
                else {
                    item.thumbnailUrl = "";
                }

            }
          


            return Ok(Data);
        }

       

           // General Get Function for dbjson database

        public string GetJson (string ObjectName)
        {
            string stringJWT = "";
            try
            {
                var Urlbase = "https://my-json-server.typicode.com/";
                var UrlSegment = "/jhlarios/dbjson";
                var UrlService = UrlSegment + "/" + ObjectName;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Urlbase);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync(UrlService).Result;
                stringJWT = response.Content.ReadAsStringAsync().Result;
            }
            catch
            {
                throw;
            }

            return stringJWT;
        }




    }
}