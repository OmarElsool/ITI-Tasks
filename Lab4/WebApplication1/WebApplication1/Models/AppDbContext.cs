using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>(ent =>
                ent.HasKey(k => new { k.CrsId, k.StdId })
            );
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.HasMany<Course>(c => c.Courses)
            //    .WithMany(d => d.Departments);

            //});
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.HasMany<Course>(c => c.Courses)
            //    .WithMany(d => d.Departments)
            //    .UsingEntity(t => t.ToTable("DeptCourse"));

            //});
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<WebApplication1.Models.Course> Course { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
    }
}
