using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class StudentHelper:IStudentHelper
{
    public IEnumerable<Student> GetAllStudents(List<Student> students)
    {
        return students
            .ToArray();
    }
    public Student GetStudentById(List<Student> students, int id)
    {
        return students.Where(x => x.ID.Equals(id)).First();
    }

    public List<Student> GetStudentByName(List<Student> students, string parameter)
    {
        return students.Where(x => x.FirstName.Contains(parameter)).ToList();
    }

    public IEnumerable<Student> AddStudent(List<Student> students, Student student)
    {
        students.Add(student);
        return students;
    }

    public IEnumerable<Student> UpdateStudent(List<Student> students, int id, string name)
    {
        Student std = students.Where(x => x.ID.Equals(id)).First();
        int i = students.IndexOf(std);
        students[i].FirstName = name;
        return students;
    }

    public IEnumerable<Student> DeleteStudent(List<Student> students, int id)
    {
        students.Remove(students.Where(obj => obj.ID.Equals(id)).First());
        return students;
    }
}