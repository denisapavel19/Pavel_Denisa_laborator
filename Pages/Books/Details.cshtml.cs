﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pavel_Denisa_laborator.Data;
using Pavel_Denisa_laborator.Models;

namespace Pavel_Denisa_laborator.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext _context;

        public DetailsModel(Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
