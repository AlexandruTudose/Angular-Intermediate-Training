using Faculty.Api.Models;

namespace Faculty.Api.Services;

public interface IPersistenceService
{
    public List<T> GetList<T>() where T : Entity;
}