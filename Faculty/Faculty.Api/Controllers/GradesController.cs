using Faculty.Api.Models;
using Faculty.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Faculty.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class GradesController : EntityController<Grade>
{
    public GradesController(IPersistenceService persistenceService) : base(persistenceService)
    {
    }

    [HttpPost]
    public override IActionResult Create(Grade entity)
    {
        if (PersistenceService.GetList<Student>().Any(s => s.Id == entity.StudentId)
            && PersistenceService.GetList<Course>().Any(c => c.Id == entity.CourseId))
        {
            return base.Create(entity);
        }

        return BadRequest();
    }

    [HttpPut]
    public override IActionResult Update(Grade entity)
    {
        if (PersistenceService.GetList<Student>().Any(s => s.Id == entity.StudentId)
            || PersistenceService.GetList<Course>().Any(c => c.Id == entity.StudentId))
        {
            return BadRequest();
        }

        return base.Update(entity);
    }
}
