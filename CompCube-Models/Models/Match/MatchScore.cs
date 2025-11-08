using CompCube_Models.Models.ClientData;

namespace CompCube_Models.Models.Match;

public class MatchScore(UserInfo user, Score? score)
{
    public readonly UserInfo User = user;
    public readonly Score? Score = score;
}