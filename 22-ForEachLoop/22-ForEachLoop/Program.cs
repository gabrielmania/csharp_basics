﻿class Program
{
    static void Main(string[] args)
    {
        // foreach loop = a simpler way to iterate over an array, but it's less flexible

        String[] cars = { "BMW", "Mustaing", "Corvette" };

        foreach (String car in cars)
        {
            Console.WriteLine(car);
        }
    }
}