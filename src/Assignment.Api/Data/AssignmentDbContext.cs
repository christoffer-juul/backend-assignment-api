using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Api.Data;

public class AssignmentDbContext(DbContextOptions<AssignmentDbContext> options) : DbContext(options)
{
    public DbSet<AssignmentModel> Assignments => Set<AssignmentModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssignmentModel>().HasData(
            new AssignmentModel { Id = 1, Name = "Design Accessibility", Level = "Advanced", Hours = 12, Status = "in-progress", IconUrl = "/images/assignments/design-icon.png" },
            new AssignmentModel { Id = 2, Name = "Figma for Beginner", Level = "Intermediate", Hours = 16, Status = "in-progress", IconUrl = "/images/assignments/figma-logo.png" },
            new AssignmentModel { Id = 3, Name = "Framer Design", Level = "Advanced", Hours = 22, Status = "completed", IconUrl = "/images/assignments/framer-logo.png" },
            new AssignmentModel { Id = 4, Name = "Frontend Development", Level = "Intermediate", Hours = 14, Status = "in-progress", IconUrl = "/images/assignments/appstore-icon.png" },
            new AssignmentModel { Id = 5, Name = "Behance Case Study", Level = "Intermediate", Hours = 18, Status = "in-progress", IconUrl = "/images/assignments/behance-logo.png" },
            new AssignmentModel { Id = 6, Name = "UI Design Fundamentals", Level = "Beginner", Hours = 10, Status = "in-progress", IconUrl = "/images/assignments/design-icon.png" },
            new AssignmentModel { Id = 7, Name = "React for Beginners", Level = "Beginner", Hours = 20, Status = "in-progress", IconUrl = "/images/assignments/appstore-icon.png" },
            new AssignmentModel { Id = 8, Name = "TypeScript Essentials", Level = "Intermediate", Hours = 14, Status = "completed", IconUrl = "/images/assignments/appstore-icon.png" },
            new AssignmentModel { Id = 9, Name = "UX Research Methods", Level = "Advanced", Hours = 18, Status = "in-progress", IconUrl = "/images/assignments/design-icon.png" },
            new AssignmentModel { Id = 10, Name = "Motion Design with After Effects", Level = "Intermediate", Hours = 24, Status = "completed", IconUrl = "/images/assignments/design-icon.png" }
        );
    }
}
