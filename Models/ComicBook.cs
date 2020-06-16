using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ComicBooksCharacters.Models
{
    public class ComicBook
    {
        //base of comicbook that reflects same structure as db
        public int ComicBookID { get; set; }
        public string ComicBookTitle { get; set; }
    }
}
