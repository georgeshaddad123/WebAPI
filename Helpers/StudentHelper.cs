using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class StudentHelper:IStudentHelper
{
    public Student GetStudentById(List<Student> students, int id)
    {
        return students.Where(x => x.ID.Equals(id)).First();
    }

    public List<Student> GetStudentByName(List<Student> students, string parameter)
    {
        return students.Where(x => x.FirstName.Contains(parameter)).ToList();
    }
}