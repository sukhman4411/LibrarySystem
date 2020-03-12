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
    public class IndexModel : PageModel
    {
        private readonly LibrarySystem.Data.ApplicationDbContext _context;

        public IndexModel(LibrarySystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<LibrarySystem.BussinessLayer.Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Authors.ToListAsync();
        }
    }
}
