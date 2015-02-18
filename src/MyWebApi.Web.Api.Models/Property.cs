using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Web.Api.Models
{
    class Property
    {
        private List<Link> _links;

        public long? PropertyId { get; set; }
        public virtual string PropertyName { get; set; }

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
