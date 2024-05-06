using System;
using System.Security.Cryptography;

class Student : Human
{
    public string name = "";
    public int age;

    public static int NumberOfStudents;

   public Student(String name, int age)
    :base ("", "", "")
    {
        this.name = name;
        this.age = age;
        NumberOfStudents++;
    }

    public Student(string name, int age, string hairColor, string eyeColor, string gender)
      : base(hairColor, eyeColor, gender)
    {
        this.name = name;
        this.age = age;
        NumberOfStudents++;
    }

    public static void printNumberOfStudents()
    {
        Console.WriteLine($"There are {NumberOfStudents} students");
    }

    public static void changeName(Student student, string name){
        student.name = name;
    }

    public void eat(String food)
    {
        Console.WriteLine($"{name} is eating {food}.");
    }
    public void sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }

    public override string ToString()
    {
        return "Denne studenten heter " + name + ".";
    }
}