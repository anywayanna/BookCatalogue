using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookCatalogue.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogue.Controllers
{
    public class HomeController : Controller
    {
        BookContext database;
        public HomeController (BookContext context)
        {
            database = context;
        }

        

        public async Task<IActionResult> Index()
        {
            return View(await database.Books.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id != null)
            {
                Book book = await database.Books.FirstOrDefaultAsync(b => b.Id == id);
                if (book != null)
                    return View(book);
            }
            else
            {
                Book book = new Book();
                return View(book);
            }
            return NotFound();
            
        }

        [HttpPost]
        public async Task<IActionResult> Update(Book book)
        {
            database.Books.Update(book);
            await database.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Book book = await database.Books.FirstOrDefaultAsync(p => p.Id == id);
                if (book != null)
                    return View(book);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Book book = await database.Books.FirstOrDefaultAsync(p => p.Id == id);
                if (book != null)
                {
                    database.Books.Remove(book);
                    await database.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}




    }
}
