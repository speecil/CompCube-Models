using CompCube_Models.Models.Events;
using CompCube_Models.Models.Packets.ServerPackets;
using CompCube_Models.Models.Packets.ServerPackets.Event;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        UserDisconnected,
        EventStarted,
        EventClosed,
        EventMapSelected,
        EventMatchStarted,
        EventScoresUpdated
    }
    
    public static ServerPacket Deserialize(string data)
    {
        var jobj = JObject.Parse(data);
        
        if (!jobj.TryGetValue("type", out var packetTypeJToken))
            throw new Exception("Could not deserialize packet!");
        
        if (!Enum.TryParse<ServerPacket.ServerPacketTypes>(packetTypeJToken.ToObject<string>(), out var userPacketType))
            throw new Exception("Could not deserialize packet type!");

        return (userPacketType switch
        {
            ServerPacketTypes.JoinResponse => JsonConvert.DeserializeObject<JoinResponsePacket>(data),
            ServerPacketTypes.MatchCreated => JsonConvert.DeserializeObject<MatchCreatedPacket>(data),
            ServerPacketTypes.OpponentVoted => JsonConvert.DeserializeObject<VotePacket>(data),
            ServerPacketTypes.MatchStarted => JsonConvert.DeserializeObject<MatchStartedPacket>(data),
            ServerPacketTypes.MatchResults => JsonConvert.DeserializeObject<MatchResultsPacket>(data),
            ServerPacketTypes.UserDisconnected => JsonConvert.DeserializeObject<UserDisconnectedPacket>(data),
            ServerPacketTypes.EventScoresUpdated => JsonConvert.DeserializeObject<EventScoresUpdated>(data),
            ServerPacketTypes.EventClosed => JsonConvert.DeserializeObject<EventClosedPacket>(data),
            ServerPacketTypes.EventMapSelected => JsonConvert.DeserializeObject<EventMapSelected>(data),
            ServerPacketTypes.EventMatchStarted => JsonConvert.DeserializeObject<EventMatchStartedPacket>(data),
            ServerPacketTypes.EventStarted => JsonConvert.DeserializeObject<EventStartedPacket>(data),
            ServerPacketTypes.PrematureMatchEnd => JsonConvert.DeserializeObject<PrematureMatchEndPacket>(data),
            _ => throw new Exception("Could not get packet type!")
        })!;
    }
}