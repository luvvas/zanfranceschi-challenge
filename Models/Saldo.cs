
using System.Text.Json.Serialization;

namespace zanfranceschi_challenge.Models
{
  public class Saldo
  {
    [JsonIgnore]
    public Guid Id { get; set; } = Guid.Empty;
    public decimal saldo { get; set; } = 0;
    public DateTime de { get; set; } = DateTime.UtcNow;
    [JsonIgnore]
    public Cliente Cliente { get; set; }
    [JsonIgnore]
    public Guid ClienteId { get; set; }
  }
}