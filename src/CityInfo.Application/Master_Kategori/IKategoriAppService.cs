using Abp.Application.Services;
using CityInfo.Master_Kategori.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Master_Kategori
{
    public interface IKategoriAppService : IApplicationService
    {
        IEnumerable<GetKategoriOutput> ListAll();
        GetKategoriOutput GetKategoriById(GetKategoriInput input);
    }
}
