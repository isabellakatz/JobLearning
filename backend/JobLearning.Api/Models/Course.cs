namespace JobLearning.Api.Models;

public class Course
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public int DurationMinutes { get; set; }
}