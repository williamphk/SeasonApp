using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeasonApp.Models;

namespace SeasonApp.Controllers
{
    public class SeasonAPIController : ApiController
    {
        /// <summary>
        /// Receives an input of the temperature and provides a message indicating the season
        /// </summary>
        /// <param name="temperature">The temperature in degrees C</param>
        /// <example>
        /// GET api/example/season/21 -> 
        /// ["Summer!","https://www.pexels.com/photo/hand-holding-a-slice-of-watermelon-with-blue-swimming-pool-water-in-the-background-2403850/"]
        /// </example>
        /// <example>
        /// GET api/example/season/17 -> 
        /// ["Fall!","https://www.pexels.com/photo/a-couple-carrying-skateboards-5838858/"]
        /// </example>
        /// <example>
        /// GET api/example/season/-15 -> 
        /// ["Winter!","https://www.pexels.com/photo/photography-of-leafless-tree-surrounded-by-snow-774531/"]
        /// </example>
        /// <returns>The associated season with the temperature</returns>
        [Route("api/SeasonAPI/GetSeason/{temperature}")]
        [HttpGet]
        public 
            Season GetSeason(int? temperature)
        {
            string season = "";
            string imgURL = "";
            if (temperature == null) {
                season = "unknown";
                imgURL = "unknown";
            }
            if (temperature > 20)
            {
                season = "Summer";
                imgURL = "https://www.pexels.com/photo/hand-holding-a-slice-of-watermelon-with-blue-swimming-pool-water-in-the-background-2403850/";
            }
            else if (temperature >= 15)
            {
                season = "Fall";
                imgURL = "https://www.pexels.com/photo/a-couple-carrying-skateboards-5838858/";
            }
            else if (temperature > 10)
            {
                season = "Spring";
                imgURL = "https://www.pexels.com/photo/photo-of-girl-wearing-bucket-hat-2344013/";
            }
            else
            {
                season = "Winter";
                imgURL = "https://www.pexels.com/photo/photography-of-leafless-tree-surrounded-by-snow-774531/";
            }

            Season SeasonInfo = new Season();
            SeasonInfo.SeasonName = season;
            SeasonInfo.ImageURL = imgURL;
            SeasonInfo.Temp = (int)temperature;


            return SeasonInfo;
        }
    }
}
