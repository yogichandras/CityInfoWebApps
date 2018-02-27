using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public interface ITempatManager:IDomainService
    {
        IEnumerable<MasterTempat> GetTempat();
        MasterTempat GetTempatById(int Id);
        MasterTempat GetTempatByIdKategori(int IdKategori);
    }
}
