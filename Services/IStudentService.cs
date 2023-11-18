using EjemploOData.Models;

namespace EjemploOData.Services;

public interface IStudentService
{
    IQueryable<Student> GetAll();

}
