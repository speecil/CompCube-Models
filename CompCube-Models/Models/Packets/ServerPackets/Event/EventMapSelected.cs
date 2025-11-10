using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets.Event;

public class EventMapSelected(VotingMap map) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.EventMapSelected;
    
    [JsonProperty("map")] public readonly VotingMap Map = map;
}