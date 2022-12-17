using Microsoft.EntityFrameworkCore;

using zanfranceschi_challenge.Models;

namespace zanfranceschi_challenge.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Saldo> Saldos { get; set; }

  }
}