using MapperLibrariesBenchmark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.MappingConfigurations
{
    public static class ExpressMapperConfiguration
    {
        public static void InitialExpressMapperConfiguration()
        {
            ExpressMapper.Mapper.Register<NetflixEpisodeDto, NetflixEpisode>();
            ExpressMapper.Mapper.Register<LangSubDto, LangSub>();
            ExpressMapper.Mapper.Register<LangSoundDto, LangSound>();
        }
    }
}
