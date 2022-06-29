using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentHelper _studentHelper;

    public StudentsController(IStudentHelper studentHelper)
    {
        _studentHelper = studentHelper;
    }

    private List<Student> listOfStudents = new List<Student>()
    {
        new Student() { Email = "georges.alhaddad02@gmail.com", FirstName = "Georges", ID = 1 },
        new Student() { Email = "hasan.dweik@gmail.com", FirstName = "Hasan", ID = 2 },
        new Student() { Email = "charbel.ashkar@gmail.com", FirstName = "Charbel", ID = 3 },
        new Student() { Email = "serge@gmail.com", FirstName = "Serge", ID = 4 }
    };

    [HttpGet("getAllStudents")]
    public IEnumerable<Student> GetAllStudents()
    {
        return _studentHelper.GetAllStudents(listOfStudents);
    }

    [HttpGet("{id}")]
    public Student GetStudentsById([FromRoute]int id)
    {
        return _studentHelper.GetStudentById(listOfStudents, id);
    }

    [HttpGet("getStudentsByName")]
    public IEnumerable<Student> GetStudentsByName([FromQuery] string parameter)
    {
        return _studentHelper.GetStudentByName(listOfStudents, parameter);
    }
    
    [HttpGet("getCurrentDate")]
    public string GetCurrentDate(string header)
    {
        CultureInfo cultureInfo = new CultureInfo(header);
        return DateTime.Now.ToString(cultureInfo);
    }

    [HttpPost("addStudent")]
    public IEnumerable<Student> AddStudent(Student student)
    {
        return _studentHelper.AddStudent(listOfStudents, student);
    }
    
    [HttpPost("updateStudent")]
    public IEnumerable<Student> UpdateStudent(int id, string name)
    {
        return _studentHelper.UpdateStudent(listOfStudents, id, name);
    }

    [HttpDelete("deleteStudent")]
    public IEnumerable<Student> DeleteStudent(int id)
    {
        return _studentHelper.DeleteStudent(listOfStudents, id);
    }
}