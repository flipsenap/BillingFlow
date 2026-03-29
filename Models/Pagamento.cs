namespace BillingFlowApi.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        
        public int CobrancaId { get; set; }
        public required Cobranca Cobranca { get; set; }
    }
}