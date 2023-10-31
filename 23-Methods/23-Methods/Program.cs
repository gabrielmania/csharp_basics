class Program
{
    static void Main(string[] args)
    {
        // method = performs a section of code, whenever it's called "invoked"
        //          benefit = let us reuse code w/o wirting it multiple times

        String name = "Gab";
        int age = 21;

        singHappyBirthday(name, age);
    }

    static void singHappyBirthday(String name, int age) 
    {
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday dear " + name);
        Console.WriteLine("You are " + age + " years old!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine();
    }
}