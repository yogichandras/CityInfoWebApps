using Abp.Application.Services;
using AutoMapper;
using CityInfo.Models;
using CityInfo.Master_Tempat;
using CityInfo.Master_Tempat.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Abp.Authorization;

namespace CityInfo.Master_Tempat
{
    [AbpAuthorize]
    public class TempatAppService:ApplicationService,ITempatAppService
    {
        private readonly ITempatManager _tempatManager;
        public TempatAppService(ITempatManager tempatManager)
        {
            _tempatManager = tempatManager;
        }

       
        public GetTempatOutput GetTempatById(GetTempatInput input)
        {
            var getTempat = _tempatManager.GetTempatById(input.Id);
            GetTempatOutput output = Mapper.Map<MasterTempat, GetTempatOutput>(getTempat);
            return output;
        }

        public GetTempatOutput GetTempatByIdKategori(GetTempatKategori input)
        {
            var getTempatKategori = _tempatManager.GetTempatByIdKategori(input.IdKategori);
            GetTempatOutput output = Mapper.Map<MasterTempat, GetTempatOutput>(getTempatKategori);
            return output;
        }

        public IEnumerable<GetTempatOutput> ListAll()
        {
            var getAll = _tempatManager.GetTempat().ToList();
            List<GetTempatOutput> output = Mapper.Map<List<MasterTempat>,List<GetTempatOutput>>(getAll);
            return output;
        }

       
    }
}
