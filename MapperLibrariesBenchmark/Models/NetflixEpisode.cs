using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrariesBenchmark.Models
{
    public class NetflixEpisode
    {
        public string? Type { get; set; }
        public bool HasHd { get; set; }
        public bool IsNSRE { get; set; }
        public string[]? Ancestor { get; set; }
        public int SeriesId { get; set; }
        public string? VideoURL { get; set; }
        public LangSub[]? LangSubs { get; set; }
        public bool IsPlayable { get; set; }
        public LangSound[]? LangSounds { get; set; }  //TODO : needed custom mapping 
        public string? RatingAlt { get; set; }
        public bool IsOriginal { get; set; }
        public bool NonPlayable {get; set; }
        public string[]? EpisodeBadges { get; set; }    
        public int EvidentualId { get; set; }  
        public string? MaturityBoard { get; set; }  
        public int NumberOfEpisodes { get; set; }   
        public string? ReleaseYearOriginal { get; set; }
        public string? AvailabilityDateMessaging { get; set; }  

    }

    public class LangSub
    {
        public string? IsoCode { get; set; } 
        public string? Bcp47Code { get; set; } 
        public string? EnglishName { get; set; } 
    }

    public class LangSound
    {
        public  string? IsoCode { get; set; }
        public  string? Bcp47Code { get; set; }
        public  string? LanguageName { get; set; }
    }
}
