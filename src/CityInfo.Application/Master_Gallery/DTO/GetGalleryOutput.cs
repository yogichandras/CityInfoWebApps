using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Master_Gallery.DTO
{
    public class GetGalleryOutput
    {
        public int Id { get; set; }
        public int id_tempat { get; set; }
        public int id_kategori { get; set; }
        public string image { get; set; }
    }
}
