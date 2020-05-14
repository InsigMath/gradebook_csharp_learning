using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) // Like Java!!! - static is associate with the type they are defined in
        {
            // var p = Program();
            // Program.Main(args); Would run forever

            var book1 = new Book("Cris individual list grade book");
            book1.AddGrade(56.8); book1.AddGrade(89.7); book1.AddGrade(75.2); book1.AddGrade(66.6);
            
            var gradebook = new List<double>() {56.8, 89.7, 75.2, 66.6};
            var book2 = new Book("Cris grouped list grade book", gradebook);

            var stats1 = book1.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats1.Low}");
            Console.WriteLine($"The highest grade is {stats1.High}");
            Console.WriteLine($"The average grade is {stats1.Average:N1}\n");

            var stats2 = book2.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats2.Low}");
            Console.WriteLine($"The highest grade is {stats2.High}");
            Console.WriteLine($"The average grade is {stats2.Average:N1}\n");

        }
    }
}
