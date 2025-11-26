using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class VotePacket : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.OpponentVoted;
    
    [JsonProperty("vote")]
    public readonly int VoteIndex;

    [JsonProperty("userId")] public readonly string UserId;

    [JsonConstructor]
    public VotePacket(int voteIndex, string userId)
    {
        VoteIndex = voteIndex;
        UserId = userId;
    }
}