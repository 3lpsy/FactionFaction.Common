using Faction.Common.Models;

namespace Faction.Common.Messages
{
  public partial class NewTransport
  {
    public string Name { get; set; }
    public int ApiKeyId { get; set; }
    public int UserId { get; set; }
  }

  public partial class TransportCreated
  {
    public bool Success;
    public Transport Transport { get; set; }
  }

  public class UpdateTransport
  {
    public int Id;
    public string Name;
    public string TransportType;
    public string Guid;
    public string Configuration;
    public bool Enabled;
    public bool Visible;
  }

  public class TransportUpdated
  {
    public bool Success;
    public Transport Transport;
  }
}
