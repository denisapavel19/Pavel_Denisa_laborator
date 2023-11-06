using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pavel_Denisa_laborator.Models;

namespace Pavel_Denisa_laborator.Data
{
    public class Pavel_Denisa_laboratorContext : DbContext
    {
        public Pavel_Denisa_laboratorContext (DbContextOptions<Pavel_Denisa_laboratorContext> options)
            : base(options)
        {
        }

        public DbSet<Pavel_Denisa_laborator.Models.Book> Book { get; set; } = default!;

        public DbSet<Pavel_Denisa_laborator.Models.Publisher>? Publisher { get; set; }

        public DbSet<Pavel_Denisa_laborator.Models.Author>? Author { get; set; }

        public DbSet<Pavel_Denisa_laborator.Models.Category>? Category { get; set; }
    }
}
