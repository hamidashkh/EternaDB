using EternaDB.DataAccessLayer;
using EternaDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaDB.Controllers
{
    public class TeamsController : Controller
    {
        private readonly AppDbContext _context;
        public TeamsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Teams> teams= _context.Teams.ToList();
            return View(teams);
        }
    }
}
