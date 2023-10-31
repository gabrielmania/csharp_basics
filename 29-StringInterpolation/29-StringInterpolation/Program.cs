class Program
{
    static void Main(string[] args)
    {
        // string interpolation = allows us to insert variables into a string literal
        //                        precede a string literal with $
        //                        {} are placeholders

        String firstName = "Gab";
        String lastName = "Man";
        int age = 21;

        Console.WriteLine($"Hello {firstName} {lastName}.");
        Console.WriteLine($"You are {age, 10} years old.");
    }
}