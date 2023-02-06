using System.ComponentModel.DataAnnotations;

namespace EternaDB.Models
{
    public class Service
    {
        public int Id { get; set; }
        [StringLength(255),Required]
        public string Name { get; set; }
        public IEnumerable<PricingService> PricingService { get; set; }

    }
}
