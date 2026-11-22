namespace JobLearning.Api.Dtos;

/// <summary>
/// Data Transfer Object (DTO) for the Course entity.
public record CourseDto(
    int Id,
    string Title,
    string Description,
    string Category,
    int DurationMinutes);