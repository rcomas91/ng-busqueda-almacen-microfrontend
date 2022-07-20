using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using winatm.Models;

namespace winatm.Models
{
    public class WinatmDB : DbContext
    {
        public WinatmDB(DbContextOptions<WinatmDB> options) : base(options)
        {

        }
        public DbQuery<SomeModel> SomeModels { get; set; }

    }
}
