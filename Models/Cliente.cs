namespace BillingFlowApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Documento { get; set; }
        public bool Ativo { get; set; } = true;
    }
}