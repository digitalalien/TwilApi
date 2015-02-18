using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Data.Entities
{
    public class Service
    {
        public virtual long ServiceId { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string ServiceDesc { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
