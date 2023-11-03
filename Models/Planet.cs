using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public class Planet : BaseEntity
{
    private const string PathToEntity = "planets/";

    protected override string EntryPath
    {
        get
        {
            return PathToEntity;
        }
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("diameter")]
    public string Diameter { get; set; }

    [JsonPropertyName("rotation_period")]
    public string RotationPeriod { get; set; }

    [JsonPropertyName("orbital_period")]
    public string orbital_period { get; set;}

    [JsonPropertyName("gravity")]
    public string Gravity { get; set; }

    [JsonPropertyName("climate")]
    public string Climate { get; set; }

    [JsonPropertyName("terrain")]
    public string Terrain { get; set; }

    [JsonPropertyName("surface_water")]
    public string  SurfaceWater { get; set; }

    [JsonPropertyName("residents")]
    public ICollection<string> Residents { get; set; }

    [JsonPropertyName("films")]
    public ICollection<string> Films { get; set; }

}
