using System;

namespace StudentMarksCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input student details
            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Mark 1: ");
            double mark1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mark 2: ");
            double mark2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mark 3: ");
            double mark3 = Convert.ToDouble(Console.ReadLine());

            // Calculate total and average marks
            double totalMarks = mark1 + mark2 + mark3;
            double averageMarks = totalMarks / 3;

            // Display results
            Console.WriteLine("\nStudent Information:");
            Console.WriteLine($"ID: {studentId}");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Mark 1: {mark1}");
            Console.WriteLine($"Mark 2: {mark2}");
            Console.WriteLine($"Mark 3: {mark3}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {averageMarks}");

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
