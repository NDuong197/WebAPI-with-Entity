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

    }
}
