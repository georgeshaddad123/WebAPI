namespace WebAPI.Abstraction;

public interface IStudentHelper
{
    public Student GetStudentById(List<Student> students, int id);
}