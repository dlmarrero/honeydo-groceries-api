using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrocAPI.Models;

    public class HoneyDoContext : DbContext
    {
        public HoneyDoContext (DbContextOptions<HoneyDoContext> options)
            : base(options)
        {
        }

        public DbSet<GrocAPI.Models.List> List { get; set; }

        public DbSet<GrocAPI.Models.Product> Product { get; set; }
    }
