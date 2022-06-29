using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class StudentHelper : IStudentHelper
{
    public IEnumerable<Student> GetAllStudents(List<Student> students)
    {
        return students
            .ToArray();
    }

    public Student GetStudentById(List<Student> students, int id)
    {
        Student s = new Student();
        try
        {
            s = students.Where(x => x.ID.Equals(id)).First();
        }
        catch (Exception e)
        {
            Console.WriteLine("The id given is not found");
            throw;
        }
        finally
        {
            Console.WriteLine("Statement executed");
        }

        return s;
    }

    public List<Student> GetStudentByName(List<Student> students, string parameter)
    {
        List<Student> s = new List<Student>();
        try
        {
            s = students.Where(x => x.FirstName.Contains(parameter)).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine("There's no one having the letter " + parameter);
            throw;
        }

        return s;
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