using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchResultsPacket(int mmrChange, int finalRedScore, int finalBlueScore) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchResults;
    
    [JsonProperty("mmrChange")]
    public readonly int MmrChange = mmrChange;
    
    [JsonProperty("redPoints")]
    public readonly int FinalRedScore = finalRedScore;
    
    [JsonProperty("bluePoints")]
    public readonly int FinalBlueScore = finalBlueScore;
}