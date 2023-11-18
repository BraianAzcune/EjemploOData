using EjemploOData.Models;
using EjemploOData.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjemploOData.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public ActionResult<IQueryable<Student>> GetAllStudents()
    {
        return Ok(this._studentService.GetAll());
    }
}
