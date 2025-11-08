using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;


public class DivisionInfo
{
    [method: JsonConstructor]
    public DivisionInfo(string division, int subDivision, string colorCode, bool glow)
    {
        Division = division;
        SubDivision = subDivision;
        Color = colorCode;
        Glow = glow;
    }

    public DivisionInfo(DivisionName divisionName, int subDivision, string colorCode, bool glow)
    {
        Division = divisionName.ToString();
        SubDivision = subDivision;
        Color = colorCode;
        Glow = glow;
    }

    [JsonProperty("division")] public string Division { get; private set; }
    [JsonProperty("subDivision")] public int SubDivision { get; private set; }
    [JsonProperty("color")] public string Color { get; private set; }
    [JsonProperty("glow")] public bool Glow { get; private set; }

    public enum DivisionName
    {
        Iron,
        Bronze,
        Silver,
        Gold,
        Platinum,
        Diamond,
        Iridescent,
        Luminal,
        Superluminal
    }
}