using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Web.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
