using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierkanteWielen.Shared.Models;

namespace VierkanteWielen.Shared.Data
{
    public class VierkanteWielenContext : IdentityDbContext
    {
        public VierkanteWielenContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Les> Lessen { get; set; }


    }
}
