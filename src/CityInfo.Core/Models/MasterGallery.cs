using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CityInfo.Models
{
    public class MasterGallery: Entity
    {
        public MasterTempat MasterTempat { get; set; }

        public MasterKategori MasterKategori { get; set; }

        [ForeignKey("MasterTempat")]
        public int id_tempat { get; set; }

        [ForeignKey("MasterKategori")]
        public int id_kategori { get; set; }

        public string image { get; set; }

        public virtual ICollection<MasterGallery> Gallery { get; set; }
    }
}
