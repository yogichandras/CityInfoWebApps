using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Models
{
   public interface IKategoriManager : IDomainService
    {
        IEnumerable<MasterKategori> GetKategori();
        MasterKategori GetKategoriById(int Id);
    }
}
