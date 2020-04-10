using System;
namespace LatihanInheritance
{
    class Constructor
    {
        static void Main(string[] args)
        {
            person person = new person("Mike", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();


            Student student = new Student("Sara", 19, "10506", "sara1234@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
