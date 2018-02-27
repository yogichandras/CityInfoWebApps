using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Master_Tempat.DTO
{
    public class GetTempatOutput
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Createdate { get; set; }
        public string Picture { get; set; }
        public int IdKategori { get; set; }
    }
}
