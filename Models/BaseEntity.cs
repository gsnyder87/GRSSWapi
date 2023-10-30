using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWapi.Models;
public abstract class BaseEntity
{
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }
    protected abstract string EntryPath { get; }
    public string GetPath() { return EntryPath; }
}
