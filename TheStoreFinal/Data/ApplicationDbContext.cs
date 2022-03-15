using System;
using Microsoft.EntityFrameworkCore;
using TheStoreFinal.Models;

namespace TheStoreFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
