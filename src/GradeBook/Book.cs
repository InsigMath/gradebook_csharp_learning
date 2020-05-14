using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book // ifp public wasnt there it would be internal = protected in C++
    {
        public Book(string name)
        {
            grades = new List<double>();
            total = 0;
            Name = name;
        }

        public Book(string name, List<double> grades_lst)
        {
            grades = grades_lst;
            total = grades.Count;
            Name = name;
        }
        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            total += 1;
        }

        public int numOfGrades()
        {
            return total;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;;
            result.Low = double.MaxValue;

            // Console.WriteLine($"Statistics for the book {name}");

            foreach(var grade in grades) {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }
        private List<double> grades; // a field cannot use var, must be explicit to
        public string Name;
        private int total; 
    }
}