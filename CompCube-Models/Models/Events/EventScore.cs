using CompCube_Models.Models.Match;

namespace CompCube_Models.Models.Events;

public class EventScore(ClientData.UserInfo user, Score? score, int placement) : MatchScore(user, score)
{
    public readonly int Placement = placement;
}