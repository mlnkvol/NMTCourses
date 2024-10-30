using Microsoft.EntityFrameworkCore;
using NMTCourses.Models; // Простір імен, де зберігаються моделі

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

	public DbSet<Course> Courses { get; set; }
	public DbSet<Teacher> Teachers { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<Student> Students { get; set; }
	public DbSet<Enrollment> Enrollments { get; set; }
}
