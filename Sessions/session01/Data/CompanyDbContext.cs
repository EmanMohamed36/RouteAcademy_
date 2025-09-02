using Microsoft.EntityFrameworkCore;
using session01.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Data
{
    internal class CompanyDbContext:DbContext
    {
        public CompanyDbContext() : base()
        { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-V690Q3O;Initial Catalog=Company;Integrated Security=True");//old connection
            optionsBuilder.UseSqlServer("Server=DESKTOP-V690Q3O; Database=Company;Trusted_Connection=True; TrustServerCertificate=True");//new connection
             
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.FName).HasMaxLength(50).IsRequired();
                entity.Property(e => e.LName).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Address).HasMaxLength(200);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Description).HasMaxLength(500);
            });

           

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.HiringDat).HasColumnType("date");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Bouns).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Salary).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Adress).HasMaxLength(200);
                entity.Property(e => e.HourRate).HasColumnType("decimal(18,2)");
            });

            
        }

    }
}
