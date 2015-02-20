using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebApi.Web.Api.Models;
using MyWebApi.Web.Common.Routing;

namespace MyWebApi.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("location")]
    public class LocationController : ApiController
    {
        [Route("", Name = "AddLocationRoute")]
        [HttpPost]
        public Location AddLocation(HttpRequestMessage requestMessage, Location newLocation)
        {
            return new Location
            {
                LocationName = "Version 1 New Location = " + newLocation.LocationName
            };
        }
    }
}
