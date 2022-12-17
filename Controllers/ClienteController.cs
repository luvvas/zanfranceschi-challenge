using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using zanfranceschi_challenge.Data;
using zanfranceschi_challenge.Dtos;
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

    [HttpPost]
    public async Task<ActionResult<List<Cliente>>> AddCliente(CreateClienteDto request)
    {
      var dbCliente = await _context.Clientes.FirstOrDefaultAsync(c => c.nome == request.nome);

      if (dbCliente == null)
      {
        var newCliente = new Cliente
        {
          nome = request.nome
        };

        _context.Clientes.Add(newCliente);
        await _context.SaveChangesAsync();

        return (await _context.Clientes.ToListAsync());
      }
      else
      {
        return Ok("This Cliente already exists");
      }
    }
  }
}