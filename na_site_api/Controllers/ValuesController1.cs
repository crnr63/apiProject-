using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Google.Maps;
using Google.Maps.StaticMaps;
using Google.Maps.Places;
using RestSharp;
using RestSharp.Authenticators;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace na_site_api.Controllers
{
    [Route("api/updateDB")]
    public class ValuesController1 : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {

            GoogleSigned.AssignAllServices(new GoogleSigned("AIzaSyCXjUvlzkfDK6ME1kTwnD1N4rlVP71aI3s"));
       
            var client = new RestClient();
            client.BaseUrl = new Uri("http://twitter.com");
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Resource = "statuses/friends_timeline.xml";

            IRestResponse response = client.Execute(request);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
