using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sasspal.DAL;
using Sasspal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sasspal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = await _context.Sliders.ToListAsync(),    
            };
            return View(homeVM);
        }
    }
}
