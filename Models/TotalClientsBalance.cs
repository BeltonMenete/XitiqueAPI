namespace XitiqueAPI.Models
{
    // This a total monthly Balance for all Clients
    public class AllClientsBalance
    {
        public Ulid Id { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
    }
}