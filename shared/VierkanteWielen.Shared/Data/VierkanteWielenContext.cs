using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierkanteWielen.Shared.Models;

namespace VierkanteWielen.Shared.Data
{
    internal class VierkanteWielenContext : IdentityDbContext
    {
        public VierkanteWielenContext()
        {
            
        }
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Les> Lessen { get; set; }


    }
}
