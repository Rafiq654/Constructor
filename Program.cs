﻿using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            person.Name = "Mike";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Sara";
            student.Age = 19;
            student.StudentId = "10506";
            student.Email = "sara1234@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
           
    }
}