using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController: ControllerBase
{
    private readonly IStudentHelper _studentHelper;
    public StudentsController(IStudentHelper studentHelper)
    {
        _studentHelper = studentHelper;
    }

    private List<Student> listOfStudents = new List<Student>()
    {
        new Student(){Email = "georges.alhaddad02@gmail.com", FirstName = "Georges", ID = 1},
        new Student(){Email = "hasan.dweik@gmail.com", FirstName = "Hasan", ID = 2},
        new Student(){Email = "charbel.ashkar@gmail.com", FirstName = "Charbel", ID = 3},
        new Student(){Email = "serge@gmail.com", FirstName = "Serge", ID = 4}
    };
    
    [HttpGet("getAllStudents")]
    public IEnumerable<Student> GetStudents()
    {
        return listOfStudents
            .ToArray();
    }

    [HttpGet("{id}")]
    public Student GetStudentsById(int id)
    {
        return _studentHelper.GetStudentById(listOfStudents, id);
    }
    
    [HttpGet("getStudentsByName")]
    public IEnumerable<Student> GetStudentsByName([FromQuery] string parameter)
    {
        return _studentHelper.GetStudentByName(listOfStudents, parameter);
    }
    
    // [HttpPost]
    // public IEnumerable<Student> AddStudent(Student student)
    // {
    //     listOfStudents.Add(student);
    //     return GetStudents();
    // }
    
    [HttpDelete]
    public IEnumerable<Student> DeleteStudent(Student student)
    {
        listOfStudents.Remove(student);
        return GetStudents();
    } 
}