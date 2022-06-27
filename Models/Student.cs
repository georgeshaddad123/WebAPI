using System.ComponentModel.DataAnnotations;

namespace WebAPI;

public class Student
{
    [Required(ErrorMessage = "Id Required")]
    public long ID { get; set; }
    [Required(ErrorMessage = "First name Required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Email Required")]
    public string Email { get; set; }
}