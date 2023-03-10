using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using zanfranceschi_challenge.Data;
using zanfranceschi_challenge.Models;

namespace zanfranceschi_challenge.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ClienteController : ControllerBase
  {
    private readonly DataContext _context;
    public ClienteController(DataContext context)
    {
      _context = context;
    }
  }
}