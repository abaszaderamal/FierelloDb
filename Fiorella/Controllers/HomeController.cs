using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = await _context.Sliders.ToListAsync(),
                SliderIntro = await _context.SliderIntro.FirstOrDefaultAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync(),
                Products = await _context.Products
                    .Where(p => p.IsDeleted == false)
                    .Include(p => p.Images)
                    .Include(p => p.Category)
                    .OrderByDescending(p => p.Id)
                    .Take(8)
                    .ToListAsync(),
                InfoVideo = await _context.InfoVideo.FirstOrDefaultAsync(),
                InfoIntro = await _context.InfoIntro.FirstOrDefaultAsync(),
                ExpertIntro = await _context.ExpertIntros.FirstOrDefaultAsync(),
                ExpertInfo = await _context.ExpertInfos.ToListAsync(),
                BlogIntro = await _context.BlogIntros.FirstOrDefaultAsync(),
                BlogInfos = await _context.BlogInfos.ToListAsync(),
                Reviews = await _context.Reviews.ToListAsync()
            };

            return View(homeVM);
        }
    }
}
