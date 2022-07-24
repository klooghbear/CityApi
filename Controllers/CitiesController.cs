﻿using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object> { 
                    new { id = 1, Name = "Dunedin" },
                    new { id = 2, Name = "Auckland" }
                });
        }
    }
}
