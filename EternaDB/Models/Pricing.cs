namespace EternaDB.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsFeatured { get; set; }
        public IEnumerable<PricingService> PricingService { get; set; }
    }
}
