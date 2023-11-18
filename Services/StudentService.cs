using EjemploOData.Models;

namespace EjemploOData.Services;

public class StudentService : IStudentService
{
    public IQueryable<Student> GetAll()
    {
        return new List<Student>{
            new() { Id = Guid.NewGuid(), Name = "Pedro", Score = 10 },
            new Student { Id = Guid.NewGuid(), Name = "Ana", Score = 90 },
            new Student { Id = Guid.NewGuid(), Name = "Carlos", Score = 85 },
            new Student { Id = Guid.NewGuid(), Name = "María", Score = 75 },
            new Student { Id = Guid.NewGuid(), Name = "Javier", Score = 98 },
            new Student { Id = Guid.NewGuid(), Name = "Isabel", Score = 82 },
        }.AsQueryable();
    }
}
