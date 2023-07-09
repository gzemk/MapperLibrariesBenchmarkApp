using AutoMapper;
using MapperLibrariesBenchmark.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.MappingConfigurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<NetflixEpisodeDto, NetflixEpisode>();
            CreateMap<LangSubDto, LangSub>();
            CreateMap<LangSoundDto, LangSound>();
        }
    }
}
