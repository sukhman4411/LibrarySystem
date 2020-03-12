﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.BussinessLayer;
using LibrarySystem.Data;

namespace LibrarySystem.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly LibrarySystem.Data.ApplicationDbContext _context;

        public DetailsModel(LibrarySystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public LibrarySystem.BussinessLayer.Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Author)
                .Include(s => s.Book).SingleOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
