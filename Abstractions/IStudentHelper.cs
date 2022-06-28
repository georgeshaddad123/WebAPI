namespace WebAPI.Abstraction;

public interface IStudentHelper
{
    public Student GetStudentById(List<Student> students, int id);
    public List<Student> GetStudentByName(List<Student> students, string parameter);
}