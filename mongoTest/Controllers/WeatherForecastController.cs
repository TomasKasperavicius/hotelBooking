using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace mongoTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private IMongoCollection<Shipwreck> _shipwreckCollection;

        public WeatherForecastController(IMongoClient client)
        {
            var database = client.GetDatabase("sample_geospatial");
            _shipwreckCollection = database.GetCollection<Shipwreck>("shipwrecks");
        }

        [HttpGet]
        public IEnumerable<Shipwreck> Get()
        {
            return _shipwreckCollection.Find(_ =>true).ToList();



        }
    }
}