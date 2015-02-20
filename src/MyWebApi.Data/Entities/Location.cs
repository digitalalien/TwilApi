using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Data.Entities
{
    class Location
    {
        private readonly IList<User> _users = new List<User>();

        public virtual long LocationId { get; set; }
        public virtual string LocationName { get; set; }
        public virtual byte[] Version { get; set; }

        public virtual IList<User> Users {
            get { return _users; }
        }
    }
}
