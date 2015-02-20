using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebApi.Web.Api.Models;

namespace MyWebApi.Web.Api.Controllers.V2
{
    [RoutePrefix("api/{apiVersion:apiVersionConstraint(v2)}/location")]
    public class LocationController : ApiController
    {
        [Route("", Name = "AddLocationRouteV2")]
        [HttpPost]
        public Location AddLocation(HttpRequestMessage requestMessage, Location newLocation) 
        {
            return new Location
            {
                LocationName = "Version 2 Location Name = " + newLocation.LocationName
            };
        }
    }
}
