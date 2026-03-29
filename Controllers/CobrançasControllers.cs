using Microsoft.AspNetCore.Mvc;
using BillingFlowApi.Models;
using BillingFlowApi.Services;
using BillingFlowApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace BillingFlowApi.Controllers
{
    [Authorize] 
    [ApiController]
    [Route("api/[controller]")]
    public class CobrancasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly CobrancaService _service;

        public CobrancasController(AppDbContext context, CobrancaService service)
        {
            _context = context;
            _service = service;
        }

        [HttpPost]
        public IActionResult Criar(Cobranca cobranca)
        {
            _context.Cobrancas.Add(cobranca);
            _context.SaveChanges();
            return Ok(cobranca);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var cobrancas = _context.Cobrancas
                .Include(c => c.Cliente)
                .ToList();

            return Ok(cobrancas);
        }

        [HttpGet("inadimplentes")]
        public IActionResult Inadimplentes()
        {
            var lista = _service.ObterInadimplentes();
            return Ok(lista);
        }
    }
}