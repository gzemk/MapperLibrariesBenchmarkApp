using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.Models
{
    public class NetflixEpisodeDto
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("has_hd")]
        public bool HasHd { get; set; }

        [JsonPropertyName("isNSRE")]
        public bool IsNSRE { get; set; }

        [JsonPropertyName("ancestor")]
        public string[]? Ancestor { get; set; }

        [JsonPropertyName("seriesId")]
        public int SeriesId { get; set; }

        [JsonPropertyName("videoURL")]
        public string? VideoURL { get; set; }

        [JsonPropertyName("lang_subs")]
        public LangSub[]? LangSubs { get; set; }

        [JsonPropertyName("isPlayable")]
        public bool IsPlayable { get; set; }

        [JsonPropertyName("lang_audio")]
        public LangSound[]? LangSounds { get; set; }  //TODO : needed custom mapping 

        [JsonPropertyName("rating_alt")]
        public string? RatingAlt { get; set; }

        [JsonPropertyName("is_original")]
        public bool IsOriginal { get; set; }

        [JsonPropertyName("non_playable")]
        public bool NonPlayable { get; set; }

        [JsonPropertyName("episodeBadges")]
        public string[]? EpisodeBadges { get; set; }

        [JsonPropertyName("evidentual_id")]
        public int EvidentualId { get; set; }

        [JsonPropertyName("maturityBoard")]
        public string? MaturityBoard { get; set; }

        [JsonPropertyName("numberOfEpisodes")]
        public int NumberOfEpisodes { get; set; }

        [JsonPropertyName("release_year_original")]
        public string? ReleaseYearOriginal { get; set; }

        [JsonPropertyName("availabilityDateMessaging")]
        public string? AvailabilityDateMessaging { get; set; }
    }

    public class LangSubDto
    {
        [JsonPropertyName("isoCode")]
        public string? IsoCode { get; set; }

        [JsonPropertyName("bcp47Code")]
        public string? Bcp47Code { get; set; }

        [JsonPropertyName("englishName")]
        public string? EnglishName { get; set; }
    }

    public class LangSoundDto
    {
        [JsonPropertyName("isoCode")]
        public string? IsoCode { get; set; }

        [JsonPropertyName("bcp47Code")]
        public string? Bcp47Code { get; set; }

        [JsonPropertyName("languageName")]
        public string? LanguageName { get; set; }
    }
}
