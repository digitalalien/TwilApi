using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Data.Entities
{
    class Property
    {
        private readonly IList<User> _users = new List<User>();

        public virtual long PropertyId { get; set; }
        public virtual string PropertyName { get; set; }
        public virtual byte[] Version { get; set; }

        public virtual IList<User> Users {
            get { return _users; }
        }
    }
}
