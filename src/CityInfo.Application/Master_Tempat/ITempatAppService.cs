using Abp.Application.Services;
using CityInfo.Master_Tempat.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Master_Tempat
{
    public interface ITempatAppService:IApplicationService
    {
        IEnumerable<GetTempatOutput> ListAll();
        GetTempatOutput GetTempatById(GetTempatInput input);

        IEnumerable<GetTempatOutput> GetTempatByIdKategori(GetTempatKategori input);
    }
}
