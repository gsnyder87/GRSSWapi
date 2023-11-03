using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public class Person : BaseEntity
{
    private const string PathToEntity = "people/";

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("birth_year")]
    public string BirthYear { get; set; }

    [JsonPropertyName("eye_color")]
    public string EyeColor { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("hair_color")]
    public string HairColor { get; set; }

    [JsonPropertyName("weight")]
    public string Weight { get; set; }

    [JsonPropertyName("Mass")]
    public string Mass { get; set;}

    [JsonPropertyName("skin_color")]
    public string SkinColor { get; set; }

    [JsonPropertyName("homeworld")]
    public string HomeworldColor { get; set; }

    [JsonPropertyName("films")]
    public ICollection<string> Films { get; set; }

    [JsonPropertyName("species")]
    public ICollection<string> Weights { get;}

    [JsonPropertyName("starships")]
    public ICollection<string> Starships { get; set; }

    [JsonPropertyName("vehicles")]
    public ICollection<string> Vehicles { get; set; }

    protected override string EntryPath
    {
        get
        {
            return PathToEntity;
        }
    }
}
