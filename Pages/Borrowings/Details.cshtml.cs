using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pavel_Denisa_laborator.Data;
using Pavel_Denisa_laborator.Models;

namespace Pavel_Denisa_laborator.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext _context;

        public DetailsModel(Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}
