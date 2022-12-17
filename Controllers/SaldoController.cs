using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using zanfranceschi_challenge.Data;
using zanfranceschi_challenge.Models;

namespace zanfranceschi_challenge.Controllers
{
  [Route("[controller]")]
  public class SaldoController : ControllerBase
  {
    private readonly DataContext _context;
    public SaldoController(DataContext context)
    {
      _context = context;
    }
  }
}