using Faculty.Api.Models;
using Faculty.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Faculty.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class StudentsController : EntityController<Student>
{
    public StudentsController(IPersistenceService persistenceService) : base(persistenceService)
    {
    }

    [HttpDelete("{id}")]
    public override IActionResult Delete(Guid id)
    {
        if (PersistenceService.GetList<Grade>().Any(g => g.StudentId == id))
        {
            return BadRequest();
        }

        return base.Delete(id);
    }

    [HttpDelete]
    public override IActionResult Delete()
    {
        if (PersistenceService.GetList<Grade>().Any())
        {
            return BadRequest();
        }

        return base.Delete();
    }
}