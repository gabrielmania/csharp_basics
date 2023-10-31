﻿namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic = "not specific to a particular data type"
            //           add <T> to: classes, methods, fields, etc.
            //           allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);
        }

        public static void DisplayElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
