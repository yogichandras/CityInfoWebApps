using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Models
{
    public class KategoriManager : DomainService, IKategoriManager
    {
        private readonly IRepository<MasterKategori> _repositoryKategori;
        public KategoriManager(IRepository<MasterKategori> repositoryKategori)
        {
            _repositoryKategori = repositoryKategori;
        }

        public IEnumerable<MasterKategori> GetKategori()
        {
            return _repositoryKategori.GetAllIncluding(x => x.Kategoris);
        }

        public MasterKategori GetKategoriById(int Id)
        {
            return _repositoryKategori.Get(Id);
        }


    }
}
