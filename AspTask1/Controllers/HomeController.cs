using AspTask1.DAL;
using AspTask1.Models;
using AspTask1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask1.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<SliderItem> sliders = _context.Sliders.ToList();
            List<Category> categories = _context.Categories.Take(6).ToList();
            HomeVM homeVM = new HomeVM {
                SliderItems = sliders,
                Categories = categories
            
            };
            return View(homeVM);
        }
    }
}
