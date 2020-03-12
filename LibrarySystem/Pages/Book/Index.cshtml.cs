using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.BussinessLayer;
using LibrarySystem.Data;

namespace LibrarySystem.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly LibrarySystem.Data.ApplicationDbContext _context;

        public IndexModel(LibrarySystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<LibrarySystem.BussinessLayer.Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
