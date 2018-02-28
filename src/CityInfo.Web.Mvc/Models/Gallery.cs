using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Web.Models
{
    public class Gallery
    {
        [Key]
        public int id { get; set; }

        public MasterTempat MasterTempat { get; set; }

        public MasterKategori MasterKategori { get; set; }

        [ForeignKey("MasterTempat")]
        public int id_tempat { get; set; }

        [ForeignKey("MasterKategori")]
        public int id_kategori { get; set; }

        public string image { get; set; }

    }
}
