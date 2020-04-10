using System;
using System.Collections.Generic;
using System.Text;
public class person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public person(string Name, int Age) {
        this.Name = Name;
        this.Age = Age;
    }

    public void GetNameAndAge()
    {
        Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
    }
}