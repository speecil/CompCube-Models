using Newtonsoft.Json;

namespace CompCube_Models.Models.Events;

[method: Newtonsoft.Json.JsonConstructor]
public class EventData(string eventName, string displayName, string description)
{
    [JsonProperty(PropertyName = "eventName")]
    public string EventName => eventName;
    
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName => displayName;
    
    [JsonProperty(PropertyName = "description")]
    public string Description => description;
}