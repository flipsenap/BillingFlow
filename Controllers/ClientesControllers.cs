using Microsoft.AspNetCore.Mvc;
using BillingFlowApi.Data;
using BillingFlowApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace BillingFlowApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_context.Clientes.ToList());
        }
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
                return NotFound();

            cliente.Ativo = false;

            _context.SaveChanges();

            return Ok("Cliente desativado");
        }
    }

}