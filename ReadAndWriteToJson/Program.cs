using System;


class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[2];

        Student student1 = new Student("Eirik", 38, "Brown", "Brown", "Male");
        Student student2 = new Student("Vegard", 29);
        //Human human = new Human("hairColor", "Brown", "Male");



        student1.eat("pizza");
        Student.changeName(student1, "Petter");
        student1.eat("pizza");
        student2.eat("ice cream");
        student1.printHairColor();
        student1.sleep();
        student2.sleep();
        Console.WriteLine(Student.NumberOfStudents);
        Student.printNumberOfStudents();
        Messages.greetings();

        students[0] = student1;
        students[1] = student2;

        /*Console.WriteLine(students[0].name);
        Console.WriteLine(students[1].name);
        Console.WriteLine(students[2]);*/

        foreach (Student student in students)
        {
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
        }
        Console.WriteLine(students.Length);
        Console.WriteLine(student1);

        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Vehicle[] vehicles = { car, bicycle, boat };

        car.Go();
        bicycle.Go();
        boat.Go();

        Vehicle[] vehicles2 = new Vehicle[3];
        vehicles2[0] = car;
        vehicles2[1] = bicycle;
        vehicles2[2] = boat;

        foreach (Vehicle vehicle in vehicles2)
        {
            vehicle.Go();
        }


        Rabit rabit = new Rabit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();
        rabit.flee();
        hawk.hunt();
        fish.hunt();
        fish.flee();


    }



}

class Vehicle
{
    public virtual void Go()
    {
        Console.WriteLine("The Vehicle is driving");
    }
}

class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The car is driving");
    }
}

class Bicycle : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The bicycle is biking");
    }
}

class Boat : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The boat is sailing");
    }
}




interface IPredator
{
    void hunt();
}

interface IPray
{
    void flee();
}

class Rabit : IPray
{
    public void flee()
    {
        Console.WriteLine("The Rabit runs away");
    }
}

class Hawk : IPredator
{
public void hunt(){
    Console.WriteLine("The Hawk is hunting");
}

}

class Fish : IPredator, IPray
{

public void hunt(){
    Console.WriteLine("The fish is hunting");
}

public void flee(){
    Console.WriteLine("The fish swims away");
}
}