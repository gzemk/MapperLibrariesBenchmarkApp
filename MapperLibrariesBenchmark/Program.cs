using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using MapperLibrariesBenchmark;
using MapperLibrariesBenchmark.MappingConfigurations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


var config = DefaultConfig.Instance
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddJob(Job.MediumRun.WithLaunchCount(1).WithToolchain(InProcessEmitToolchain.Instance));

BenchmarkRunner.Run<MapperLibrariesBenchmarkContainer>(config);
Console.ReadLine();



