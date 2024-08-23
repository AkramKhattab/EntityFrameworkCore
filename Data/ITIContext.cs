using EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;

public class ITIContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<StudCourse> StudCourses { get; set; }
    public DbSet<CourseInst> CourseInsts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Akram;Database=CompanyG03DB;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Using conventions for Student
        modelBuilder.Entity<Student>()
            .HasKey(s => s.ID);

        // Using Fluent API for Department
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(d => d.ID);
            entity.Property(d => d.Name).IsRequired().HasMaxLength(50);
            entity.Property(d => d.HiringDate).HasColumnType("date");
        });

        // Using Data Annotations for Course (in the Course class)
        // [Key]
        // public int ID { get; set; }
        // [Required]
        // [MaxLength(100)]
        // public string Name { get; set; }

        // Using Fluent API for Instructor
        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(i => i.ID);
            entity.Property(i => i.Name).IsRequired().HasMaxLength(100);
            entity.Property(i => i.Salary).HasColumnType("decimal(18,2)");
            entity.Property(i => i.HourRate).HasColumnType("decimal(18,2)");
            entity.Property(i => i.Bonus).HasColumnType("decimal(18,2)");
        });

        // Using conventions for Topic
        modelBuilder.Entity<Topic>()
            .HasKey(t => t.ID);

        // Using Fluent API for StudCourse (junction table)
        modelBuilder.Entity<StudCourse>(entity =>
        {
            entity.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            entity.Property(sc => sc.Grade).HasColumnType("decimal(5,2)");
        });

        // Using Fluent API for CourseInst (junction table)
        modelBuilder.Entity<CourseInst>(entity =>
        {
            entity.HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
            entity.Property(ci => ci.Evaluate).HasMaxLength(255);
        });
    }
}