﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Web.Api.Models
{
    class User
    {
        private List<Link> _links;

        public long? UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public long ParentUserId { get; set; }

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
