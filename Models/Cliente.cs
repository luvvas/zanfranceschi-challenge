namespace zanfranceschi_challenge.Models
{
  public class Cliente
  {
    public Guid Id { get; set; } = Guid.Empty;
    public string nome { get; set; } = string.Empty;
    public Saldo Saldo { get; set; } = new Saldo();
  }
}