using System.ComponentModel.DataAnnotations;

namespace JobLearning.Api.Dtos;

public class CreateCourseDto
{
    [Required]
    public string Title { get; init; } = string.Empty;

    [Required]
    public string Description { get; init; } = string.Empty;

    [Required]
    public string Category { get; init; } = string.Empty;

    // <summary>
    /// The duration of the course in minutes. 
    /// Must be a positive integer, at least 1. This property is validated using the [Range] attribute to ensure that the value falls within the specified range.
    /// </summary>
    [Range(1, int.MaxValue)]
    public int DurationMinutes { get; init; }
}