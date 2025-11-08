using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Match;

public record MatchResultsData(MatchScore Winner, MatchScore Loser, int MmrChange, VotingMap? Map, bool Premature, int Id, DateTime Time);