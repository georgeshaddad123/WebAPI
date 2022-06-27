using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class StudentHelper:IStudentHelper
{
    public Student GetStudentById(List<Student> students, int id)
    {
        Student s = students.Where(x => x.ID.Equals(id)).First();
        return s;
    }
}