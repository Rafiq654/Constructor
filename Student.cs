using System;
using System.Collections.Generic;
using System.Text;
public class Student : person
{
    public string StudentId { get; set; }
    public string Subject { get; set; }
    public string Email { get; set; } 
    public Student(string Name, int Age, string studentId, string Email) : base (Name, Age)
    {
        this.Name = Name;
        this.Age = Age;
        this.StudentId = StudentId;
        this.Email = Email;

    }

}