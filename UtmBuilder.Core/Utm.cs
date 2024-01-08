using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm 
    {
        public Url Url { get; set; }
        public string Source { get; set; }
        public string Medium { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Term { get; set; }
        public string Content { get; set; }
    }
}
