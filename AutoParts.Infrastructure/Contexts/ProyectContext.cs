using AutoParts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Infrastructure.Contexts
{
    public class ProyectContext : DbContext
    {
        public ProyectContext() : base("AutoParts")
        {
        }
        
        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
