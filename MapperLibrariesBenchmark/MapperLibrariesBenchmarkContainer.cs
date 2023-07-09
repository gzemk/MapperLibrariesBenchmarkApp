using AgileObjects.AgileMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;
using MapperLibrariesBenchmark.MappingConfigurations;
using MapperLibrariesBenchmark.Models;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Nelibur.ObjectMapper;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MapperLibrariesBenchmark
{
    [MemoryDiagnoser]
    [DryJob]
    [ShortRunJob]
    [SimpleJob(RunStrategy.Throughput)]
    [KeepBenchmarkFiles(false)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByMethod)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
    public class MapperLibrariesBenchmarkContainer
    {
        private static MapperlyMapperConfiguration? _mapperlyMapperConfiguration;
        private AutoMapper.IMapper _autoMapper;
        public MapperLibrariesBenchmarkContainer()
        {
        }

        [GlobalSetup]
        public void GlobalSetup()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var serviceProvider = services.BuildServiceProvider();
            _autoMapper = serviceProvider.GetRequiredService<AutoMapper.IMapper>();

            _mapperlyMapperConfiguration = new MapperlyMapperConfiguration();
            TinyMapperConfiguration.InitialTinyMapperConfiguration();
            ExpressMapperConfiguration.InitialExpressMapperConfiguration();

        }

        private static NetflixEpisodeDto ConvertFromJson()
        {
            NetflixEpisodeDto netflixEpisodeDto;
            var json = File.ReadAllText("C:\\Projects\\Benchmarks\\MapperLibrariesBenchmarkApp\\MapperLibrariesBenchmark\\NetflixEpisode.json");
            netflixEpisodeDto = JsonConvert.DeserializeObject<NetflixEpisodeDto>(json)!;
            return netflixEpisodeDto;
        }

        [Benchmark]
        public void TinyMapperBenchmark()
        {
            TinyMapper.Map<NetflixEpisode>(ConvertFromJson());
        }

        [Benchmark]
        public void MapperlyBenchmark()
        {
            _mapperlyMapperConfiguration?.Map(ConvertFromJson());
        }

        [Benchmark]
        public void AgileMapperBenchmark()
        {
            Mapper.Map(ConvertFromJson()).ToANew<NetflixEpisode>();
        }

        [Benchmark]
        public void ExpressMapperBenchmark()
        {
            ExpressMapper.Mapper.Map<NetflixEpisodeDto, NetflixEpisode>(ConvertFromJson());
        }

        [Benchmark]
        public void AutoMapperBenchmark()
        {
            NetflixEpisodeDto netflixEpisodeDto = ConvertFromJson();
            _autoMapper.Map<NetflixEpisode>(netflixEpisodeDto);
        }

        [Benchmark]
        public void Mapster()
        {
            NetflixEpisodeDto netflixEpisodeDto = ConvertFromJson();
            netflixEpisodeDto.Adapt<NetflixEpisode>();
        }

        [Benchmark]
        public void ReflectionMapperBenchmark()
        {
            NetflixEpisodeDto netflixEpisodeDto = ConvertFromJson();
            NetflixEpisode netflixEpisode = ReflectionMapperConfiguration.ReflectionMapper<NetflixEpisodeDto, NetflixEpisode>(netflixEpisodeDto);
        }

        [Benchmark]
        public void ValueInjecterMapper()
        {
            NetflixEpisodeDto netflixEpisodeDto = ConvertFromJson();
            NetflixEpisode netflixEpisode = Omu.ValueInjecter.Mapper.Map<NetflixEpisode>(netflixEpisodeDto);
        }

        [Benchmark]
        public void FastMapperBenchmar()
        {
            NetflixEpisodeDto netflixEpisodeDto = ConvertFromJson();
            NetflixEpisode netflixEpisode = FastMapper.NetCore.TypeAdapter.Adapt<NetflixEpisodeDto, NetflixEpisode>(netflixEpisodeDto);
        }
    }
}
