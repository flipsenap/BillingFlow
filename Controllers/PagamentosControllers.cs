using Microsoft.AspNetCore.Mvc;
using BillingFlowApi.Models;
using BillingFlowApi.Services;

namespace BillingFlowApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagamentosController : ControllerBase
    {
        private readonly PagamentoService _service;

        public PagamentosController(PagamentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Pagar(Pagamento pagamento)
        {
            var resultado = _service.RegistrarPagamento(pagamento);
            return Ok(resultado);
        }
    }
}