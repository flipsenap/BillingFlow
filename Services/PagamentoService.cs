using BillingFlowApi.Data;
using BillingFlowApi.Models;

namespace BillingFlowApi.Services
{
    public class PagamentoService
    {
        private readonly AppDbContext _context;

        public PagamentoService(AppDbContext context)
        {
            _context = context;
        }

        public Pagamento RegistrarPagamento(Pagamento pagamento)
        {
            var cobranca = _context.Cobrancas.FirstOrDefault(c => c.Id == pagamento.CobrancaId);

            if (cobranca == null)
                throw new Exception("Cobrança não encontrada");

           
            cobranca.Pago = true;

            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();

            return pagamento;
        }
    }
}