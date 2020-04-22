using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VB_PROJECTS_NOTES.Models;

    public class GeneralContext : DbContext
    {
        public GeneralContext (DbContextOptions<GeneralContext> options)
            : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>()
            .Property(b => b.Active)
            .HasDefaultValueSql("1");
    }

    public DbSet<VB_PROJECTS_NOTES.Models.Region> Region { get; set; }

        public DbSet<VB_PROJECTS_NOTES.Models.Country> Country { get; set; }

        public DbSet<VB_PROJECTS_NOTES.Models.Project> Project { get; set; }
    }
