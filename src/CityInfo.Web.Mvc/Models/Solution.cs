using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Web.Models
{
    public class Solution : DbContext
    {
        public Solution(DbContextOptions<Solution> options) : base(options) { }

        public DbSet<Person> Person { get; set; }

        public DbSet<MasterTempat> Tempat { get; set; }

        public DbSet<MasterKategori> Kategori { get; set; }



    }

    
}
