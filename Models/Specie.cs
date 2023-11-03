using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public class Specie : BaseEntity
{
    private const string PathToEntity = "species/";
    protected override string EntryPath
    {
        get
        {
            return PathToEntity;
        }
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("classification")]
    public string Classification { get; set; }

    [JsonPropertyName("designation")]
    public string Designation { get; set; }

    [JsonPropertyName("average_height")]
    public string AverageHeight { get; set; }

    [JsonPropertyName("average_lifespan")]
    public string AverageLifespan { get; set;}

    [JsonPropertyName("eye_colors")]
    public string EyeColors { get; set; }

    [JsonPropertyName("hair_colors")]
    public string HairColors { get; set;}

    [JsonPropertyName("skin_colors")]
    public string SkinColors { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("homeworld")]
    public string Homeworld { get; set; }

    [JsonPropertyName("people")]
    public ICollection<string> People { get; set; }

    [JsonPropertyName("films")]
    public ICollection<string> Films { get;}

}
