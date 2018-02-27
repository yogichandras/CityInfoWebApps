using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Web.Models
{
    public class MasterKategori
    {

        [Key]
        public int id { get; set; }

        [StringLength(200)]
        public string kategori { get; set; }
    }
}
