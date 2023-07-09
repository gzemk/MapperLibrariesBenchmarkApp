using MapperLibrariesBenchmark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.Mapping
{
    public static class ManuallyMapperConfiguration
    {
        public static NetflixEpisode Map(NetflixEpisodeDto netflixEpisodeDto)
        {
            return new NetflixEpisode()
            {
                Type = netflixEpisodeDto.Type,
                HasHd = netflixEpisodeDto.HasHd,
                IsNSRE = netflixEpisodeDto.IsNSRE,
                Ancestor = netflixEpisodeDto.Ancestor,
                SeriesId = netflixEpisodeDto.SeriesId,
                VideoURL = netflixEpisodeDto.VideoURL,
                LangSubs = netflixEpisodeDto!.LangSubs?.Select(langSub => new LangSub()
                {
                    IsoCode = langSub.IsoCode,
                    Bcp47Code = langSub.Bcp47Code,
                    EnglishName = langSub.EnglishName
                }).ToArray(),
                IsPlayable = netflixEpisodeDto.IsPlayable,
                LangSounds = netflixEpisodeDto!.LangSounds?.Select(langSound => new LangSound()
                {
                    Bcp47Code = langSound.Bcp47Code,
                    IsoCode = langSound.IsoCode,
                    LanguageName = langSound.LanguageName
                }).ToArray(),
                RatingAlt = netflixEpisodeDto!.RatingAlt,
                IsOriginal = netflixEpisodeDto.IsOriginal,
                NonPlayable = netflixEpisodeDto.NonPlayable,
                EpisodeBadges = netflixEpisodeDto.EpisodeBadges,
                EvidentualId = netflixEpisodeDto.EvidentualId,
                MaturityBoard = netflixEpisodeDto!.MaturityBoard,
                NumberOfEpisodes = netflixEpisodeDto!.NumberOfEpisodes,
                ReleaseYearOriginal = netflixEpisodeDto!.ReleaseYearOriginal,
                AvailabilityDateMessaging = netflixEpisodeDto!.AvailabilityDateMessaging
            };
        }

    }
}
