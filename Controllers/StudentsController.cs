using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController: ControllerBase
{
    private List<Student> listOfStudents = new List<Student>()
    {
        new Student(){Email = "georges.alhaddad02@gmail.com", FirstName = "Georges", ID = 1}
    };
    
    [HttpGet("GetStudents")]
    public IEnumerable<Student> GetStudents()
    {
        return listOfStudents
            .ToArray();
    }

    [HttpGet("{id}")]
    public IEnumerable<Student> GetStudentsById(int id)
    {
        List<Student> studentList = listOfStudents.Where(x => x.ID.Equals(id)).ToList();    
        return studentList;
    }
    
    [HttpGet("getStudentsByName")]
    public IEnumerable<Student> GetStudentsByName([FromQuery] string param) 
    {
        List<Student> studentList = listOfStudents.Where(x => x.FirstName.Contains(param)).ToList();    
        return studentList;
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