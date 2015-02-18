using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Data.Entities
{
    public class User
    {
        public virtual long UserId { get; set; }
        public virtual string Username { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual long ParentUserId { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
