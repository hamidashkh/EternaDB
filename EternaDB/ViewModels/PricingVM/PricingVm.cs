using EternaDB.Models;

namespace EternaDB.ViewModels.PricingVM
{
    public class PricingVm
    {
        public IEnumerable<Pricing> Pricings { get; set; }
        public IEnumerable<Service> Services { get; set; }


    }
}
