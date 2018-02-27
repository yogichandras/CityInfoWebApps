using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CityInfo.Models
{
    public class MasterTempat : Entity
    {
        [StringLength(400)]
      
        public string Title { get; set; }

        [StringLength(400)]
       
        public string Createdate { get; set; }

        [StringLength(400)]
         public string Picture { get; set; }

        public int IdKategori { get; set; }

        public virtual ICollection<MasterTempat> Tempat { get; set; }
    }
}
