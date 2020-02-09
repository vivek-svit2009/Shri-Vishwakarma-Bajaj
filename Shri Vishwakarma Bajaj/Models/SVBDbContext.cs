using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shri_Vishwakarma_Bajaj.Models
{
    public class SVBDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}