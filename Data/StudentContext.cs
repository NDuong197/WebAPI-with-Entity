using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using WebAPI.Models;
namespace WebAPI.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) //webapi
        {
        }

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired(true);

            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired(true);

            modelBuilder.Entity<Student>()
                .Property(s => s.Class)
                .IsRequired(true);

            modelBuilder.Entity<Student>()
                .Property(s => s.Photo)
                .IsRequired(false);
        }
    }
}