using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // constructor = a special method in a class
        //               same name as the class name
        //               can be used to assign arguments to fields when creating an object

        //Human human1 = new Human("Rick", 65);
        //Human human2 = new Human("Morty", 16);

        //human1.Eat();
        //human1.Sleep();

        //human2.Eat();
        //human2.Sleep();

        Car car1 = new Car("Ford", "Mustang", 2022, "red");
        Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

        car1.Drive();
        car2.Drive();
    }
}

//class Human
//{
//    public String name;
//    public int age;

//    public Human(String name, int age) 
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public void Eat()
//    {
//        Console.WriteLine(name + " is eating");
//    }

//    public void Sleep()
//    {
//        Console.WriteLine(name + " is sleeping");
//    }
//}

class Car
{
    String make;
    String model;
    int year;
    String color;

    public Car(String make, String model, int year, String color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public void Drive()
    {
        Console.WriteLine("You drive the " + make + " " + model);
    }
}