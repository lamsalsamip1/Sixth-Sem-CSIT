using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMVC.Models;

namespace StudentMVC.Data
{
    public class StudentMVCContext : DbContext
    {
        public StudentMVCContext (DbContextOptions<StudentMVCContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMVC.Models.Faculty> Faculty { get; set; } = default!;
        public DbSet<StudentMVC.Models.Student> Student { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Student and Faculty
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Faculty)
                .WithMany(f => f.Students)
                .HasForeignKey(s => s.faculty_id);
        }
    }
}
