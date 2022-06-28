using System.ComponentModel.DataAnnotations;

namespace WebAPI;

public class Student
{
    [Required(ErrorMessage = "Id Required")]
    public long ID { get; set; }
    [MinLength(4, ErrorMessage = "Please enter at least 4 characters")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Email Required")]
    public string Email { get; set; }
}