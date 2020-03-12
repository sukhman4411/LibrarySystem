using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibrarySystem.BussinessLayer;
using LibrarySystem.Data;

namespace LibrarySystem.Pages.Student
{
    public class CreateModel : PageModel
    {
        private readonly LibrarySystem.Data.ApplicationDbContext _context;

        public CreateModel(LibrarySystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorID"] = new SelectList(_context.Authors, "ID", "AuthorName");
        ViewData["BookID"] = new SelectList(_context.Books, "ID", "BookName");
            return Page();
        }

        [BindProperty]
        public LibrarySystem.BussinessLayer.Student Student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}