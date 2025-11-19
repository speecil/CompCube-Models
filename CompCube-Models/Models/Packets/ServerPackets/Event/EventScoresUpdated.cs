using CompCube_Models.Models.Events;

namespace CompCube_Models.Models.Packets.ServerPackets.Event;

public class EventScoresUpdated(List<EventScore> scores) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.EventScoresUpdated;

    public readonly List<EventScore> Scores = scores;
}