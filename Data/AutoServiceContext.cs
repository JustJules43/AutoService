using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoService.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Data
{
    public class AutoServiceContext : DbContext
    {
        public AutoServiceContext(DbContextOptions<AutoServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
    }
}
