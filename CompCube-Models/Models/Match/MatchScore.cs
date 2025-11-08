using CompCube_Models.Models.ClientData;

namespace CompCube_Models.Models.Match;

public class MatchScore(CompCube_Models.Models.ClientData.UserInfo user, Score? score)
{
    public readonly CompCube_Models.Models.ClientData.UserInfo User = user;
    public readonly Score? Score = score;
}