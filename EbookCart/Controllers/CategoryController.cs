using EbookCart.Data;
using EbookCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace EbookCart.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            List<Category> listCategory = _db.Categories.ToList();
            return View(listCategory);
        }
    }
}
