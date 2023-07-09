using MapperLibrariesBenchmark.Models;
using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.MappingConfigurations
{
    public static class TinyMapperConfiguration
    {
        public static void InitialTinyMapperConfiguration()
        {
            TinyMapper.Bind<NetflixEpisodeDto, NetflixEpisode>();
            TinyMapper.Bind<LangSubDto, LangSub>();
            TinyMapper.Bind<LangSoundDto, LangSound>();
        }
    }
}
