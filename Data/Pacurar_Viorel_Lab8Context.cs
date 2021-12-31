using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pacurar_Viorel_Lab8.Models;

namespace Pacurar_Viorel_Lab8.Data
{
    public class Pacurar_Viorel_Lab8Context : DbContext
    {
        public Pacurar_Viorel_Lab8Context (DbContextOptions<Pacurar_Viorel_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pacurar_Viorel_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pacurar_Viorel_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pacurar_Viorel_Lab8.Models.Category> Category { get; set; }
    }
}
