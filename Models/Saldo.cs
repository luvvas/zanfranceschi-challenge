
namespace zanfranceschi_challenge.Models
{
  public class Saldo
  {
    public Guid Id { get; set; } = Guid.Empty;
    public decimal saldo { get; set; } = 0;
    public DateTime de { get; set; } = DateTime.UtcNow;
    public Cliente Cliente { get; set; }
    public Guid ClienteId { get; set; }
  }
}