using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the height of the triangle: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i)); // Print spaces
            Console.WriteLine(new string('*', 2 * i - 1)); // Print stars
        }
    }
}
