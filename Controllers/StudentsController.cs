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
        new Student(){Email = "georges.alhaddad02@gmail.com", FirstName = "Georges", ID = 1}
    };
    
    [HttpGet("getStudents")]
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
    public IEnumerable<Student> GetStudentsByName([FromQuery] string param) 
    {
        List<Student> studentList = listOfStudents.Where(x => x.FirstName.Contains(param)).ToList();    
        return studentList;
    }

    // [HttpGet]
    // public string GetCurrentDate([FromQuery] string param)
    // {
    //     return DateTime.Now.ToString();
    // }
    //
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