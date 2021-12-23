using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Varro_Szilard_Arnold_Lab8.Models;

namespace Varro_Szilard_Arnold_Lab8.Data
{
    public class Varro_Szilard_Arnold_Lab8Context : DbContext
    {
        public Varro_Szilard_Arnold_Lab8Context (DbContextOptions<Varro_Szilard_Arnold_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Varro_Szilard_Arnold_Lab8.Models.Book> Book { get; set; }

        public DbSet<Varro_Szilard_Arnold_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Varro_Szilard_Arnold_Lab8.Models.Category> Category { get; set; }
    }
}
