using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class GovernmentDbContext : DbContext
    {

        public GovernmentDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-AT94SBBO\SQLEXPRESS;Database=GovernmentDB;Trusted_Connection=True;");
            }

            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Party> Parties { get; set; }

        public DbSet<Politician> Politicians { get; set; }

        public DbSet<Position> Positions { get; set; }
    }
}
