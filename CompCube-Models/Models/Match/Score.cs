using Newtonsoft.Json;

namespace CompCube_Models.Models.Match;

public class Score(int points, float relativeScore, bool proMode, int misses, bool fullCombo)
{
    public static Score Empty => new(0, 0f, false, 0, true);
    public readonly int Points = points;
    public readonly float RelativeScore = relativeScore;
    public readonly bool ProMode = proMode;
    public readonly int Misses = misses;
    public readonly bool FullCombo = fullCombo;

    public string Serialize() => JsonConvert.SerializeObject(this);

    public static Score? Deserialize(string? json)
    {
        return json == null ? null : JsonConvert.DeserializeObject<Score>(json);
    }
}