namespace WebAPI.Abstraction;

public interface IStudentHelper
{
    public IEnumerable<Student> GetAllStudents(List<Student> studentList);
    public Student GetStudentById(List<Student> students, int id);
    public List<Student> GetStudentByName(List<Student> students, string parameter);
    public IEnumerable<Student> AddStudent(List<Student> students, Student student);
    public IEnumerable<Student> UpdateStudent(List<Student> students, int id, string name);
    public IEnumerable<Student> DeleteStudent(List<Student> students, int id);
}