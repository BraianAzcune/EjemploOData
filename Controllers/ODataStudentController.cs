using EjemploOData.Models;
using EjemploOData.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace EjemploOData.Controllers;
// estos dos atributos Route y ApiController no se pueden usar para Odata
//[Route("api/[controller]")]
//[ApiController]

public class ODataStudentController : ODataController
{
    private readonly IStudentService _studentService;

    public ODataStudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }


    [EnableQuery]
    public ActionResult<IQueryable<Student>> Get()
    {
        return Ok(this._studentService.GetAll());
    }
}
