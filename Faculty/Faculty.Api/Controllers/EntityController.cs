using Faculty.Api.Models;
using Faculty.Api.Services;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Faculty.Api.Controllers;

public abstract class EntityController<T> : ControllerBase where T : Entity
{
    protected readonly IPersistenceService PersistenceService;

    protected EntityController(IPersistenceService persistenceService)
    {
        PersistenceService = persistenceService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = PersistenceService.GetList<T>();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var result = PersistenceService.GetList<T>().FirstOrDefault(e => e.Id == id);
        return Ok(result);
    }

    [HttpPost]
    public virtual IActionResult Create(T entity)
    {
        var entities = PersistenceService.GetList<T>();
        entity.Id = entity.Id == Guid.Empty || entities.Exists(e => e.Id == entity.Id) ? Guid.NewGuid() : entity.Id;
        entities.Add(entity);
        var url = HttpContext.Request.GetEncodedUrl();
        return Created(new Uri(@$"{url}/{entity.Id}", UriKind.Absolute), entity);
    }

    [HttpPut]
    public virtual IActionResult Update(T entity)
    {
        var entities = PersistenceService.GetList<T>();
        entities.RemoveAll(e => e.Id == entity.Id);
        entities.Add(entity);
        return Ok();
    }

    [HttpDelete("{id}")]
    public virtual IActionResult Delete(Guid id)
    {
        var entities = PersistenceService.GetList<T>();
        entities.RemoveAll(e => e.Id == id);
        return Ok();
    }

    [HttpDelete]
    public virtual IActionResult Delete()
    {
        var entities = PersistenceService.GetList<T>();
        entities.RemoveAll(e => true);
        return Ok();
    }
}
