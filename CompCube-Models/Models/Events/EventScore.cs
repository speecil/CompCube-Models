using CompCube_Models.Models.Match;

namespace CompCube_Models.Models.Events;

public class EventScore(MatchScore score, int placement) : MatchScore(score.User, score.Score)
{
    public readonly int Placement = placement;
}