using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class TempatManager:DomainService,ITempatManager
    {
        private readonly IRepository<MasterTempat> _repositoryTempat;
        public TempatManager(IRepository<MasterTempat> repositoryTempat)
        {
            _repositoryTempat = repositoryTempat;
        }

        public IEnumerable<MasterTempat> GetTempat()
        {
            return _repositoryTempat.GetAllIncluding(x => x.Tempat);
        }

        public MasterTempat GetTempatById(int Id)
        {
            return _repositoryTempat.Get(Id);
        }

        public MasterTempat GetTempatByIdKategori(int IdKategori)
        {
            return _repositoryTempat.Get(IdKategori);
        }


    }
}
