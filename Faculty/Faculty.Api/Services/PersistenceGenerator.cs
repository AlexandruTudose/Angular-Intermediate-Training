using Faculty.Api.Models;

namespace Faculty.Api.Services;

public class PersistenceGenerator
{
    public (List<Course> courses, List<Student> students, List<Grade> grades) GenerateEntities()
    {
        var students = new List<Student>();
        var courses = new List<Course>();
        var grades = new List<Grade>();

        for (var i = 0; i < 1000; i++)
        {
            var year = Constants.Year.MinBy(s => Guid.NewGuid());
            var birthDate = GetRandomBirthDateFromYear(Constants.ReferenceYear + year);

            students.Add(new Student
            {
                Id = Guid.NewGuid(),
                RegistrationNumber = GetAlphaNumericString(6),
                FirstName = Constants.FirstNames.OrderBy(s => Guid.NewGuid()).First(),
                LastName = Constants.LastNames.OrderBy(s => Guid.NewGuid()).First(),
                Year = year,
                Group = Constants.Group.OrderBy(s => Guid.NewGuid()).First(),
                Scholarship = Constants.Scholarship.MinBy(s => Guid.NewGuid()),
                BirthDate = birthDate
            });
        }

        for (int i = 0; i < Constants.CourseNames.Count; i++)
        {
            courses.Add(new Course
            {
                Id = Guid.NewGuid(),
                Title = Constants.CourseNames[i],
                Year = i % 4 + 1,
                Semester = i % 2 + 1,
                Credits = Constants.Credits.MinBy(s => Guid.NewGuid())
            });
        }

        for (int i = 0; i < 1000; i++)
        {
            grades.Add(new Grade
            {
                Id = Guid.NewGuid(),
                CourseId = courses[i % (courses.Count - 2)].Id,
                StudentId = students.OrderBy(s => Guid.NewGuid()).First().Id,
                Value = Constants.Grades.MinBy(s => Guid.NewGuid()),
                Date = GetRandomBirthDateFromYear(2020)
            });
        }

        return (courses, students, grades);
    }

    string GetAlphaNumericString(int length)
    {
        return new(Enumerable.Repeat(Constants.AlphanumericChars, length)
            .Select(s => s[_random.Next(s.Length)]).ToArray());
    }

    DateTime GetRandomBirthDateFromYear(int year)
    {
        var startDate = new DateTime(year, 1, 1);
        var endDate = new DateTime(year + 1, 1, 1);
        int range = (endDate - startDate).Days;
        return startDate.AddDays(_random.Next(range));
    }

    private readonly Random _random = new();
}