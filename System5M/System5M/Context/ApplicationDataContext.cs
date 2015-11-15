using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System5M.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace System5M.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        //public DbSet<AppUser> Users { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}