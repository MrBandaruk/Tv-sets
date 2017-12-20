using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TvSets.Models;

namespace TvSets.Entity
{
    public class TvContext : DbContext
    {
        public TvContext() : base("TVSetDB") { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Tvset> Tvsets { get; set; }
    }
}