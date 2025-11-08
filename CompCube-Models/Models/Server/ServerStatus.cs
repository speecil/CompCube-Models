using Newtonsoft.Json;

namespace CompCube_Models.Models.Server;

public class ServerStatus(
    string[] allowedGameVersions,
    string[] allowedModVersions,
    ServerState.State state)
{
    [JsonProperty("allowedGameVersions")]
    public readonly string[] AllowedGameVersions = allowedGameVersions;
    
    [JsonProperty("allowedModVersions")]
    public readonly string[] AllowedModVersions = allowedModVersions;
    
    [JsonProperty("state")]
    public readonly ServerState.State State = state;
}