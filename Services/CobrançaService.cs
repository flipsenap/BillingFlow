using BillingFlowApi.Data;
using BillingFlowApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BillingFlowApi.Services
{
    public class CobrancaService
    {
        private readonly AppDbContext _context;

        public CobrancaService(AppDbContext context)
        {
            _context = context;
        }

        public List<Cobranca> ObterInadimplentes()
        {
            var hoje = DateTime.Now;

            return _context.Cobrancas
                .Include(c => c.Cliente)
                .Where(c => !c.Pago && c.DataVencimento < hoje)
                .ToList();
        }
    }
}