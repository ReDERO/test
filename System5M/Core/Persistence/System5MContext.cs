﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class System5MContext : IdentityDbContext<User>
    {
        public System5MContext()
            : base("System5MConnection", throwIfV1Schema: false)
        {
        }

        public static System5MContext Create()
        {
            return new System5MContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<System5MContext, Configuration>());
        }
    }
}
