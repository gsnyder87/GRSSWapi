using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public class Vehicle : BaseEntity
{
    private const string PathToEntity = "vehicles/";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("vehicle_class")]
    public string? VehicleClass { get; set; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    [JsonPropertyName("length")]
    public string? Length { get; set; }

    [JsonPropertyName("crew")]
    public string? Crew { get; set; }

    [JsonPropertyName("passengers")]
    public string? Passengers { get; set; }

    [JsonPropertyName("max_atmosphering_speed")]
    public string? MaxAtmospheringSpeed { get; set; }

    [JsonPropertyName("cargo_capacity")]
    public string? CargoCapacity { get; set; }

    [JsonPropertyName("consumables")]
    public string? Consumables { get; set; }

    [JsonPropertyName("films")]
    public  ICollection<string>? Films { get; set; }

    [JsonPropertyName("pilots")]
    public ICollection<string>? Pilots { get; set; }

    protected override string EntryPath
    {
        get { return PathToEntity; }
    }
}
