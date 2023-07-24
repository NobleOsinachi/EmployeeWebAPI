public class Student
{
    
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Major { get; set; }

    
    public Student()
    {
    }

    public Student(int studentId, string firstName, string lastName, DateTime dateOfBirth, string address, string email, string phoneNumber, string major)
    {
        StudentId = studentId;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
        Major = major;
    }
}
