using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.UserPackets;

public class VotePacket : UserPacket
{
    public override UserPacketTypes PacketType => UserPacketTypes.Vote;

    [JsonProperty("vote")]
    public readonly int VoteIndex;

    [JsonConstructor]
    public VotePacket(int voteIndex)
    {
        VoteIndex = voteIndex;
    }
}