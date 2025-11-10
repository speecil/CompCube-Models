using Newtonsoft.Json;

namespace CompCube_Models.Models.Events;

[method: Newtonsoft.Json.JsonConstructor]
public class EventData(string eventName, string displayName, string description, bool availableToJoin)
{
    [JsonProperty(PropertyName = "eventName")]
    public string EventName => eventName;
    
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName => displayName;
    
    [JsonProperty(PropertyName = "description")]
    public string Description => description;
    
    [JsonProperty(PropertyName = "availableToJoin")]
    public bool AvailableToJoin { get; set; } = availableToJoin;
}