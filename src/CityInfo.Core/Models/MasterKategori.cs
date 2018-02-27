using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CityInfo.Models
{
    public class MasterKategori : Entity
    {
        [StringLength(400)]
        public string kategori { get; set; }

        public virtual ICollection<MasterKategori> Kategoris { get; set; }
    }
}
