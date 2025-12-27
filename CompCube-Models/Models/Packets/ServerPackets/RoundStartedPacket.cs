using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class RoundStartedPacket(VotingMap[] maps, int votingTime, int round) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.RoundStarted;

    [JsonProperty("maps")]
    public readonly VotingMap[] Maps = maps;

    [JsonProperty("votingTime")]
    public readonly int VotingTime = votingTime;

    [JsonProperty("round")] 
    public readonly int Round = round;
}