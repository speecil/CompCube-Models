using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets.Event;

public class EventMatchStartedPacket(VotingMap votingMap) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.EventMatchStarted;

    [JsonProperty("map")] public VotingMap Map => votingMap;
}