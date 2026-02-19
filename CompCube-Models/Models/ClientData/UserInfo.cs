using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class UserInfo(string username, string userId, int mmr, DivisionInfo division, Badge? badge, long rank, string? discordId, bool banned, int wins, int totalGames, int winstreak, int highestWinstreak)
{
    [JsonProperty("username")]
    public string Username { get; private set; } = username;

    [JsonProperty("userId")]
    public string UserId { get; private set; } = userId;

    // change to beatleader later
    [JsonProperty("profilePictureLink")]
    public string ProfilePictureLink { get; private set; } = "https://cdn.scoresaber.com/avatars/" + (userId.Length == 17 ? $"{userId}.jpg" : "oculus.png");

    [JsonProperty("mmr")]
    public int Mmr { get; private set; } = mmr;

    [JsonProperty("badge")]
    public Badge? Badge { get; private set; }= badge;

    [JsonProperty("rank")]
    public long Rank { get; private set; }= rank;

    [JsonProperty("discordId")]
    public string? DiscordId { get; private set; } = discordId;

    [JsonProperty("banned")]
    public bool Banned { get; private set; } = banned;

    [JsonProperty("division")] public DivisionInfo Division { get; private set; } = division;

    [JsonProperty("wins")] public int Wins { get; private set; } = wins;
    [JsonProperty("losses")] public int TotalGames { get; private set; } = totalGames;
    [JsonProperty("winstreak")] public int Winstreak { get; private set; } = winstreak;
    [JsonProperty("highestWinstreak")] public int HighestWinstreak { get; private set; } = highestWinstreak;
}