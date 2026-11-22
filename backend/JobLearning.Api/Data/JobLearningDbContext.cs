using JobLearning.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace JobLearning.Api.Data;

public class JobLearningDbContext : DbContext
{
    public JobLearningDbContext(DbContextOptions<JobLearningDbContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses => Set<Course>();
}