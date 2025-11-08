using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets;

public abstract class ServerPacket : Packet
{
    [JsonProperty("type")]
    public abstract ServerPacketTypes PacketType { get; }
    
    public enum ServerPacketTypes
    {
        JoinResponse,
        MatchCreated,
        OpponentVoted,
        MatchStarted,
        MatchResults,
        PrematureMatchEnd,
        EventStarted,
        OutOfEvent
    }
}