using JobLearning.Api.Data;
using JobLearning.Api.Dtos;
using JobLearning.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobLearning.Api.Controllers;

[ApiController]
// The [Route] attribute specifies the base route for all actions in this controller. 
// In this case, it indicates that the controller will handle requests to the "api/courses" endpoint.
[Route("api/courses")]
public class CoursesController : ControllerBase
{
    private readonly JobLearningDbContext _dbContext;

    public CoursesController(JobLearningDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<CourseDto>>> GetCourses(
        CancellationToken cancellationToken)
    {
        var courses = await _dbContext.Courses
            .OrderBy(course => course.Id)
            .Select(course => new CourseDto(
                course.Id,
                course.Title,
                course.Description,
                course.Category,
                course.DurationMinutes))
            .ToListAsync(cancellationToken);

        return Ok(courses);
    }

    /// <summary>
    /// Creates a new course based on the provided CreateCourseDto.
    [HttpPost]
    public async Task<ActionResult<CourseDto>> CreateCourse(
    [FromBody] CreateCourseDto request,
    CancellationToken cancellationToken)
    {
        var course = new Course
        {
            Title = request.Title,
            Description = request.Description,
            Category = request.Category,
            DurationMinutes = request.DurationMinutes
        };

        _dbContext.Courses.Add(course);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var response = new CourseDto(
            course.Id,
            course.Title,
            course.Description,
            course.Category,
            course.DurationMinutes);

        return StatusCode(StatusCodes.Status201Created, response);
    }
}

