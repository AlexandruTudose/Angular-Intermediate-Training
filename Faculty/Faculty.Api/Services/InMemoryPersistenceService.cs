using Faculty.Api.Models;

namespace Faculty.Api.Services;

public class InMemoryPersistenceService : IPersistenceService
{
    private readonly List<Course> _courses;
    private readonly List<Student> _students;
    private readonly List<Grade> _grades;

    public InMemoryPersistenceService()
    {
        (_courses, _students, _grades) = new PersistenceGenerator().GenerateEntities();
    }

    public List<T> GetList<T>() where T : Entity
    {
        if (typeof(T) == typeof(Student))
        {
            return _students as List<T> ?? new List<T>();
        }

        if (typeof(T) == typeof(Course))
        {
            return _courses as List<T> ?? new List<T>();
        }

        if (typeof(T) == typeof(Grade))
        {
            return _grades as List<T> ?? new List<T>();
        }

        return new List<T>();
    }
}