using EternaDB.DataAccessLayer;
using EternaDB.Models;
using EternaDB.ViewModels.PricingVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaDB.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Pricing> pricings=await _context.Pricings.Include(p=>p.PricingService).ToListAsync();
            IEnumerable<Service> services=await _context.Services.ToListAsync();

            PricingVm pricingVm=new PricingVm
            {
                Pricings= pricings,
                Services= services
            };

            return View(pricingVm);
        }
    }
}
