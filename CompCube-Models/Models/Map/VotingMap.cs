using Newtonsoft.Json;

namespace CompCube_Models.Models.Map;

public class VotingMap
{
    [JsonProperty("hash")]
    public readonly string Hash;

    [JsonProperty("difficulty")]
    public readonly DifficultyType Difficulty;

    [JsonProperty("category")] 
    public readonly string Category;

    [JsonConstructor]
    public VotingMap(string hash, DifficultyType difficulty, string category)
    {
        Hash = hash;
        Difficulty = difficulty;
        Category = category;
    }
    
    public enum DifficultyType
    {
        Easy,
        Normal,
        Hard,
        Expert,
        ExpertPlus
    }
}