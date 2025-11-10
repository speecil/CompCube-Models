namespace CompCube_Models.Models.Packets.ServerPackets.Event;

public class EventClosedPacket : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.EventClosed;
}