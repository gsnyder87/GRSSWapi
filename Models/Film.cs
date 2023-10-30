using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public class Film : BaseEntity
{

    private const string PathToEntity = "films/";

    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    [JsonPropertyName("openingCrawl")]
    public string? OpeningCrawl { get; set; }
    
    [JsonPropertyName("director")]
    public string? Director { get; set; }

    [JsonPropertyName("producer")]
    public string? Producer { get; set; }

    [JsonPropertyName("releaseDate")]
    public string? ReleaseDate { get; set; }

    [JsonPropertyName("species")]
    public ICollection<string>? Species { get; set; }

    [JsonPropertyName("starships")]
    public ICollection<string>? Starships { get; set; }

    [JsonPropertyName("characters")]
    public ICollection<string>? Characters { get; set; }

    [JsonPropertyName("planets")]
    public ICollection<string>? Planets { get; set; }
    protected override string EntryPath
    {
        get
        {
            return PathToEntity;
        }
    }
}
