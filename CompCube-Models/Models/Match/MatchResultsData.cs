using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Match;

public class MatchResultsData(MatchScore winner, MatchScore loser, int mmrChange, VotingMap? map, bool premature, int id, DateTime time)
{
    public readonly MatchScore Winner = winner;
    public readonly MatchScore Loser = loser;
    public readonly int MmrChange = mmrChange;
    public readonly VotingMap? Map = map;
    public readonly bool Premature = premature;
    public readonly int Id = id;
    public readonly DateTime Time = time;
}