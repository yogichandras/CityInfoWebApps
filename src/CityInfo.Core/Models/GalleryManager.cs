using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityInfo.Models
{
    public class GalleryManager : DomainService, IGalleryManager
    {
        private readonly IRepository<MasterGallery> _repositoryGallery;
        public GalleryManager(IRepository<MasterGallery> repositoryGallery)
        {
            _repositoryGallery = repositoryGallery;
        }

        public IEnumerable<MasterGallery> GetGallery()
        {
            return _repositoryGallery.GetAllIncluding(x => x.Gallery);
        }

        public IEnumerable<MasterGallery> GetGalleryByIdKategori(int id_kategori)
        {
            return _repositoryGallery.GetAll().Where(t => t.id_kategori == id_kategori).ToList();
        }

        public IEnumerable<MasterGallery> GetGalleryByIdTempat(int id_tempat)
        {
            return _repositoryGallery.GetAll().Where(t => t.id_tempat == id_tempat).ToList();
        }
    }
}
