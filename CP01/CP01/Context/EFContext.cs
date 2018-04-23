using System;
using System.Data.Entity;
using CP01.Models;

namespace CP01.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }

        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}
