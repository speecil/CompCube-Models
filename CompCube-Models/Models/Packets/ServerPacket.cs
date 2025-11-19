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

        switch (userPacketType)
        {
            case ServerPacketTypes.JoinResponse:
                return JsonConvert.DeserializeObject<JoinResponsePacket>(data);
            case ServerPacketTypes.MatchCreated:
                return JsonConvert.DeserializeObject<MatchCreatedPacket>(data);
            case ServerPacketTypes.OpponentVoted:
                return JsonConvert.DeserializeObject<OpponentVotedPacket>(data);
            case ServerPacketTypes.MatchStarted:
                return JsonConvert.DeserializeObject<MatchStartedPacket>(data);
            case ServerPacketTypes.MatchResults:
                return JsonConvert.DeserializeObject<MatchResultsPacket>(data);
            case ServerPacketTypes.PrematureMatchEnd:
                return JsonConvert.DeserializeObject<PrematureMatchEndPacket>(data);
            case ServerPacketTypes.EventScoresUpdated:
                return JsonConvert.DeserializeObject<EventScoresUpdated>(data);
            case ServerPacketTypes.EventClosed:
                return JsonConvert.DeserializeObject<EventClosedPacket>(data);
            case ServerPacketTypes.EventMapSelected:
                return JsonConvert.DeserializeObject<EventMapSelected>(data);
            case ServerPacketTypes.EventMatchStarted:
                return JsonConvert.DeserializeObject<EventMatchStartedPacket>(data);
            case ServerPacketTypes.EventStarted:
                return JsonConvert.DeserializeObject<EventStartedPacket>(data);
            default:
                throw new Exception("Could not get packet type!");
        }
    }
}