using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets
{
    [method: JsonConstructor]
    public class MatchStartedPacket(
        VotingMap mapSelected,
        int transitionToGameWait,
        int startingWait,
        UserInfo opponent) : ServerPacket
    {
        public override ServerPacketTypes PacketType => ServerPacketTypes.MatchStarted;

        [JsonProperty("map")]
        public readonly VotingMap MapSelected = mapSelected;

        [JsonProperty("transitionToGameTime")]
        public readonly int TransitionToGameWait = transitionToGameWait;
    
        [JsonProperty("startingTime")]
        public readonly int StartingWait = startingWait;

        [JsonProperty("opponent")] 
        public readonly UserInfo Opponent = opponent;
    }
}