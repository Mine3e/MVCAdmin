
using AdminMVC.DAL;
using AdminMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AdminMVC.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> Index()
        {
            List<Product> products= await _context.Products.Include(x=>x.ProductPhotos).Where(x=>x.ProductPhotos.Count>0).ToListAsync();
            return View(products);
        }
        public IActionResult Detail(int? id)
        {
            return View();
        }

    }
}
