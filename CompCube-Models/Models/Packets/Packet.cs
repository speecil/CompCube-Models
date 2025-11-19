using System.Text;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets;

public abstract class Packet
{
    public byte[] SerializeToBytes() => Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
}