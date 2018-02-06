using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication9.Models;

namespace WebApplication9.Models
{
    public class Wiewmodel
    {
        //public Catagory catagory { get; set; }
        public IEnumerable<User> Ie_user { get; set; }
        public IEnumerable<Role> Ie_role { get; set; }
        public IEnumerable<Table> Ie_table { get; set; }
    }
}