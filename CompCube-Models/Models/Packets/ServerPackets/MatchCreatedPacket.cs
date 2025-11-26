using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using CompCube_Models.Models.Match;
using CompCube_Server.Gameplay.Match;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class MatchCreatedPacket(VotingMap[] maps, TeamData redData, TeamData blueData, int votingTime) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchCreated;
    
    [JsonProperty("votingOptions")]
    public readonly VotingMap[] Maps = maps;

    [JsonProperty("votingTime")] public readonly int VotingTime = votingTime;

    [JsonProperty("redTeam")] public readonly TeamData RedTeam = redData;

    [JsonProperty("blueTeam")] public readonly TeamData BlueTeam = blueData;
}