using Abp.Application.Services;
using Abp.Authorization;
using AutoMapper;
using CityInfo.Master_Kategori.DTO;
using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityInfo.Master_Kategori
{
    [AbpAuthorize]
    public class KategoriAppService : ApplicationService, IKategoriAppService
    {
        private readonly IKategoriManager _KategoriManager;
        public KategoriAppService(IKategoriManager KategoriManager)
        {
            _KategoriManager = KategoriManager;
        }

        public GetKategoriOutput GetKategoriById(GetKategoriInput input)
        {
            var getKategori = _KategoriManager.GetKategoriById(input.Id);
            GetKategoriOutput output = Mapper.Map<MasterKategori, GetKategoriOutput>(getKategori);
            return output;
        }

        public IEnumerable<GetKategoriOutput> ListAll()
        {
            var getAll = _KategoriManager.GetKategori().ToList();
            List<GetKategoriOutput> output = Mapper.Map<List<MasterKategori>, List<GetKategoriOutput>>(getAll);
            return output;
        }

    }
}
