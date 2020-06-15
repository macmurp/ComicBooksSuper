using System;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MVC_ComicBooksCharacters.Models;

namespace MVC_ComicBooksCharacters.Controllers
{
    public class HomeController : Controller
    {
        private ComicBookContext _ctx = null;
        public HomeController(ComicBookContext ctx)
        {
            _ctx = ctx;

            //ComicBookContext cbtxt = new ComicBookContext();
            //cbtxt.Database.EnsureCreated();
            //ComicBook c = new ComicBook { ComicBookTitle = "Steven Universe" };
            //cbtxt.ComicBooks.Add(c);
            //cbtxt.SaveChanges();

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_ctx);
        }

    }

}
