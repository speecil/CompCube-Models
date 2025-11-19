using CompCube_Models.Models.Events;
using CompCube_Models.Models.Match;

namespace CompCube_Models.Models.Packets.ServerPackets.Event;

public class EventScoresUpdated(List<EventScore> matchScores) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.EventScoresUpdated;
    
    public readonly List<EventScore> MatchScores = matchScores;
}