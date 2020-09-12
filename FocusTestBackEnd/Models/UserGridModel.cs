using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusTestBackEnd.Models
{
    public class UserGridModel
    {

        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
