using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class UserDisconnectedPacket(string userId) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.UserDisconnected;

    [JsonProperty("userId")] public readonly string UserId = userId;
}