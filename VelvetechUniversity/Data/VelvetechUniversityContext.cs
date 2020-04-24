using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VelvetechUniversity.Models;

namespace VelvetechUniversity.Data
{
    public class VelvetechUniversityContext : DbContext
    {
        public VelvetechUniversityContext (DbContextOptions<VelvetechUniversityContext> options)
            : base(options)
        {
            
        }

        public DbSet<VelvetechUniversity.Models.Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<VelvetechUniversity.Models.Student>()
                .HasIndex(s => s.Nickname)
                .IsUnique();
            builder.Entity<VelvetechUniversity.Models.Student>()
                .Property(p => p.Gender)
                .HasConversion(
                v => v.ToString(),
                v => (Gender)Enum.Parse(typeof(Gender), v));
        }
    }
}
