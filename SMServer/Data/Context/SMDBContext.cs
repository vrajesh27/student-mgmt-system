
using System;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace SMContext
{
    public class SMDBContext : DbContext
    {
        public SMDBContext(DbContextOptions<SMDBContext> options)
            : base(options)
        {
        }

        public DbSet<StudentDataModel> Students { get; set; }

        public DbSet<GradeDataModel> Grades { get; set; }
    }
}
