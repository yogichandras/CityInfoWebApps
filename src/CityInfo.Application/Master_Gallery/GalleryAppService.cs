using Abp.Application.Services;
using Abp.Authorization;
using AutoMapper;
using CityInfo.Master_Gallery.DTO;
using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityInfo.Master_Gallery
{
    [AbpAuthorize]
    public class GalleryAppService : ApplicationService, IGalleryAppService
    {
        private readonly IGalleryManager _galleryManager;
        public GalleryAppService(IGalleryManager galleryManager)
        {
            _galleryManager = galleryManager;
        }

        public IEnumerable<GetGalleryOutput> GetGalleryByIdKategori(GetGalleryInput input)
        {
            var getGallery = _galleryManager.GetGalleryByIdKategori(input.id_kategori).ToList();
            List<GetGalleryOutput> output = Mapper.Map<List<MasterGallery>, List<GetGalleryOutput>>(getGallery);
            return output;
        }

        public IEnumerable<GetGalleryOutput> GetGalleryByIdTempat(GetGalleryTempat input)
        {
            var getTempat = _galleryManager.GetGalleryByIdTempat(input.id_tempat).ToList();
            List<GetGalleryOutput> output = Mapper.Map<List<MasterGallery>, List<GetGalleryOutput>>(getTempat);
            return output;
        }

        public IEnumerable<GetGalleryOutput> ListAll()
        {
            var getAll = _galleryManager.GetGallery().ToList();
            List<GetGalleryOutput> output = Mapper.Map<List<MasterGallery>, List<GetGalleryOutput>>(getAll);
            return output;
        }
    }
}
