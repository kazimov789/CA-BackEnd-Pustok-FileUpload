using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P328Pustok.DAL;
using P328Pustok.Models;
using P328Pustok.ViewModels;

namespace P328Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly PustokContext _context;

        public BookController(PustokContext pustokContext)
        {
            _context = pustokContext;
        }
        public IActionResult Index(int page=1, string search=null)
        {
            var query = _context.Books
                .Include(x => x.Author).Include(x => x.Genre).AsQueryable();

            if (search != null)
                query = query.Where(x => x.Name.Contains(search));
            
            ViewBag.Search = search;

            return View(PaginatedList<Book>.Create(query,page,1));
        }

    }
}
