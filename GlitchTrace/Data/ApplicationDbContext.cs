using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using GlitchTrace.Models;
using Microsoft.AspNetCore.Identity;

namespace GlitchTrace.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Project> Project { get; set; }
        private const string ADMIN_ID = "d3f1708f-93a9-4c1c-8b79-49febc0c152d";
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seed role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "AdminId",
                Name = "Administrator",
                NormalizedName = "ADMIN"
            });
            //seed user roles
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "AdminId",
                UserId = ADMIN_ID
            });
        }
    }
}
