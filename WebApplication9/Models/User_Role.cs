namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Role
    {
        public int id { get; set; }

        public int? Role_id { get; set; }

        public int? User_id { get; set; }

        public int Table_id { get; set; }

        public virtual Role Role { get; set; }

        public virtual Table Table { get; set; }

        public virtual User User { get; set; }
    }
}
