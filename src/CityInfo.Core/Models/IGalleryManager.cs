using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Models
{
    public interface IGalleryManager : IDomainService
    {
        IEnumerable<MasterGallery> GetGallery();
        IEnumerable<MasterGallery> GetGalleryByIdTempat(int id_tempat);
        IEnumerable<MasterGallery> GetGalleryByIdKategori(int id_kategori);
    }
}
