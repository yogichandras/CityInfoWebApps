using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Web.Models
{
    public class MasterTempat
    {
        [Key]
        public int id{ get; set; }

        [StringLength(400)]
        [Required]
        public string title { get; set; }

        [StringLength(400)]
        [Required]
        public string createdate { get; set; }

        [StringLength(400)]
        [Required]
        public string picture { get; set; }

        [Required]
        public int idKategori { get; set; }


    }
}
