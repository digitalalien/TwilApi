using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Web.Api.Models
{
    public class Location
    {
        private List<Link> _links;

        public long? LocationId { get; set; }
        public virtual string LocationName { get; set; }

        public List<User> Staff { get; set; }

        public List<Link> Links
        {
            get { return _links ?? (_links = new List<Link>()); }
            set { _links = value; }
        }

        public void AddLink(Link link)
        {
            Links.Add(link);
        }
    }
}
