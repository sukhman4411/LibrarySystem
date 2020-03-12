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
    public class DetailsModel : PageModel
    {
        private readonly LibrarySystem.Data.ApplicationDbContext _context;

        public DetailsModel(LibrarySystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public LibrarySystem.BussinessLayer.Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books.SingleOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
