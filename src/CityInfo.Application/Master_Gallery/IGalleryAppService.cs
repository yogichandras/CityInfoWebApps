using Abp.Application.Services;
using CityInfo.Master_Gallery.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Master_Gallery
{
    public interface IGalleryAppService : IApplicationService
    {
        IEnumerable<GetGalleryOutput> ListAll();
        IEnumerable<GetGalleryOutput> GetGalleryByIdKategori(GetGalleryInput input);

        IEnumerable<GetGalleryOutput> GetGalleryByIdTempat(GetGalleryTempat input);
    }
}
