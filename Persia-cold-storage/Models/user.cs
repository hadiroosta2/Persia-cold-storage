using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Persia_cold_storage.Models
{
    public class user
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string name { get; set; }

    }
}