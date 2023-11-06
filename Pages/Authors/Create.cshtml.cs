using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pavel_Denisa_laborator.Data;
using Pavel_Denisa_laborator.Models;

namespace Pavel_Denisa_laborator.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext _context;

        public CreateModel(Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Author == null || Author == null)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
