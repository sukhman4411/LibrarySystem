using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.BussinessLayer;
using LibrarySystem.Data;

namespace LibrarySystem.Pages.Author
{
    public class DeleteModel : PageModel
    {
        private readonly LibrarySystem.Data.ApplicationDbContext _context;

        public DeleteModel(LibrarySystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LibrarySystem.BussinessLayer.Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Authors.SingleOrDefaultAsync(m => m.ID == id);

            if (Author == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Authors.FindAsync(id);

            if (Author != null)
            {
                _context.Authors.Remove(Author);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
