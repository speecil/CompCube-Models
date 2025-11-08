using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets.Event;

[method: JsonConstructor]
public class EventStartedPacket() : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.EventStarted;
}