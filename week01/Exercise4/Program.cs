using System;
using System.Collections.Generic;
using System.Linq; // Para usar funciones como Min, Max, Average, etc.

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }

            numbers.Add(input);
        }

        // Core Requirements
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge: Smallest positive number
        int smallestPositive = numbers
            .Where(n => n > 0)
            .DefaultIfEmpty() // por si no hay positivos
            .Min();

        if (smallestPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        // Stretch Challenge: Sort and display list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
