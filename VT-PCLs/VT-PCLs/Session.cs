using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT_PCLs
{
    public class Session
    {
        public Guid ID { get; set; }
        public Tuple<String, String> Players { get; set; }
        public bool Active { get; set; }
        public bool Full { get; set; }
    }
}