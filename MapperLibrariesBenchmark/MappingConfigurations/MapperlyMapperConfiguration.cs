using MapperLibrariesBenchmark.Models;
using Riok.Mapperly.Abstractions;

namespace MapperLibrariesBenchmark.MappingConfigurations
{
    [Mapper]
    public partial class MapperlyMapperConfiguration
    {
        public partial NetflixEpisode Map(NetflixEpisodeDto netflixEpisodeDto);
    }
}
