namespace BillingFlowApi.Models
{
    public class Cobranca
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; } = false;

        // Relacionamento
        public int ClienteId { get; set; }
        public required Cliente Cliente { get; set; }
    }
}