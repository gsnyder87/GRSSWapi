using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public class Starship : BaseEntity
{
    private const string PathToEntity = "starships/";

    protected override string EntryPath
    {
        get
        {
            return PathToEntity;
        }
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("starship_class")]
    public string StarshipClass { get; set; }

    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }

    [JsonPropertyName("cost_in_credits")]
    public string CostInCredits { get; set; }

    [JsonPropertyName("length")]
    public string Length { get; set; }

    [JsonPropertyName("crew")]
    public string Crews { get; set; }

    [JsonPropertyName("passengers")]
    public string Passengers { get; set; }

    [JsonPropertyName("max_atmosphering_speed")]
    public string MaxAtmospheringSpeed { get; set; }

    [JsonPropertyName("hypderdrive_rating")]
    public string HyperDriveRating { get; set; }

    [JsonPropertyName("MGLT")]
    public string MegaLights { get; set; }

    [JsonPropertyName("cargo_capacity")]
    public string CargoCapacity { get; set; }

    [JsonPropertyName("consumables")]
    public string Consumables { get; set;}

    [JsonPropertyName("films")]
    public ICollection<string> Films { get; set;}

    [JsonPropertyName("pilots")]
    public ICollection<string> Pilots { get;}
}
