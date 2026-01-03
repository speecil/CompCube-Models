namespace CompCube_Server.Models.CompCube_Models.Models.Contributors;

public class Contributor(string name, string role, string profilePictureLink)
{
    public readonly string Name = name;
    public readonly string Role = role;
    public readonly string ProfilePictureLink = profilePictureLink;
}