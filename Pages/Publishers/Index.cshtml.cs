using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pavel_Denisa_laborator.Data;
using Pavel_Denisa_laborator.Models;

namespace Pavel_Denisa_laborator.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext _context;

        public IndexModel(Pavel_Denisa_laborator.Data.Pavel_Denisa_laboratorContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
