using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesWebApp.Models;

namespace SallesWebApp.Data
{
    public class SallesWebAppContext : DbContext
    {
        public SallesWebAppContext (DbContextOptions<SallesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<SallesWebApp.Models.Departament> Departament { get; set; } = default!;
    }
}
