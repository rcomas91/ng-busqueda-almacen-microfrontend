using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sistia.Models;

namespace Sistia.Models
{
    public class SistiaDB :DbContext
    {
        public SistiaDB(DbContextOptions<SistiaDB> options) : base(options)
        {
        }
        

        public DbSet<Articulo> Articulos { get; set; }

    }
}
