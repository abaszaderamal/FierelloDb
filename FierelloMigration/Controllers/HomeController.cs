using FierelloMigration.DAL;
using FierelloMigration.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FierelloMigration.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;}

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Slidertext =await _context.SliderText.FirstOrDefaultAsync()
            };
            return View(homeVM);
        }
    }
}
