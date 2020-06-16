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

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //passes comicbookcontext into the view to be used
            return View(_ctx);
        }

    }

}
