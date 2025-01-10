using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());
            
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        } while (inputNumber != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}