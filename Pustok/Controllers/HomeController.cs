using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.Models;
using Pustok.ViewModels;
using System.Diagnostics;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _context;

        public HomeController(PustokContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                FeaturedBooks = _context.Books.Include(x=>x.Author).Include(x=>x.BookImages).Where(x => x.IsFeatured).Take(10).ToList(),
                NewBooks = _context.Books.Include("Author").Include(x => x.BookImages).Where(x => x.IsNew).Take(10).ToList(),
                DiscountedBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.DiscountPercent>0).Take(10).ToList(),
            };
            return View();
        }
    }
}