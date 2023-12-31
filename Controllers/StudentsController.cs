﻿using EjemploOData.Models;
using EjemploOData.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace EjemploOData.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<IQueryable<Student>> GetAllStudents()
    {
        return Ok(this._studentService.GetAll());
    }
}
