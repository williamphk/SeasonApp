using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeasonApp.Controllers
{
    public class SeasonAPIController : ApiController
    {
        /// <summary>
        /// Receives an input of the temperature and provides a message indicating the season
        /// </summary>
        /// <param name="temperature">The temperature in degrees C</param>
        /// <example>GET api/example/season/21 -> "Summer!"</example>
        /// <example>GET api/example/season/17 -> "Fall!"</example>
        /// <example>GET api/example/season/-15 -> "Winter!"</example>
        /// <returns>The associated season with the temperature</returns>
        [Route("api/SeasonAPI/GetSeason/{temperature}")]
        [HttpGet]
        public string GetSeason(int? temperature)
        {
            string season = "";
            if (temperature == null) return "unknown";

            if (temperature > 20)
            {
                season = "Summer";
            }
            else if (temperature >= 15)
            {
                season = "Fall";
            }
            else if (temperature > 10)
            {
                season = "Spring";
            }
            else
            {
                season = "Winter";
            }
            //string message = "The season is " + season + "!";
            return season;
        }
    }
}
