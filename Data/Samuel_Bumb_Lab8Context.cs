using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Samuel_Bumb_Lab8.Models;

namespace Samuel_Bumb_Lab8.Data
{
    public class Samuel_Bumb_Lab8Context : DbContext
    {
        public Samuel_Bumb_Lab8Context (DbContextOptions<Samuel_Bumb_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Samuel_Bumb_Lab8.Models.Book> Book { get; set; }

        public DbSet<Samuel_Bumb_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Samuel_Bumb_Lab8.Models.Category> Category { get; set; }
    }
}
