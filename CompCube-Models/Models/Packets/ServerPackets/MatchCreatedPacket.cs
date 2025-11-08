using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class MatchCreatedPacket : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchCreated;
    
    [JsonProperty("votingOptions")]
    public readonly VotingMap[] Maps;
    
    [JsonProperty("opponent")]
    public readonly CompCube_Models.Models.ClientData.UserInfo Opponent;

    [JsonConstructor]
    public MatchCreatedPacket(VotingMap[] maps, CompCube_Models.Models.ClientData.UserInfo opponent)
    {
        Maps = maps;
        Opponent = opponent;
    }
}