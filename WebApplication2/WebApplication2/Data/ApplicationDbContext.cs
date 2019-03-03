using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DegreeRequirement> DegreeRequirements { get; set; }
        public DbSet<Credits> Credits { get; set; }
        public DbSet<DegreeCredit> DegreeCredits { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<StudentId> StudentIds { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Term> Terms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DegreeRequirement>().ToTable("Degree");
            modelBuilder.Entity<Credits>().ToTable("Credit");
            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredit");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<StudentId>().ToTable("Student");
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<Term>().ToTable("StudentTerm");
        }
    }
}
