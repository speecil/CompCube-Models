using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class OpponentVotedPacket : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.OpponentVoted;
    
    [JsonProperty("vote")]
    public readonly int VoteIndex;

    [JsonConstructor]
    public OpponentVotedPacket(int voteIndex)
    {
        VoteIndex = voteIndex;
    }
}