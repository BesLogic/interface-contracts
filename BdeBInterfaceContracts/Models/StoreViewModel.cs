namespace BdeBInterfaceContracts.Models
{
    public class StoreViewModel
    {
        public Product Product { get; set; }
        public User User { get; set; }
        public int? NewUserId { get; set; }
        public decimal PriceToPay { get; set; }
    }
}
