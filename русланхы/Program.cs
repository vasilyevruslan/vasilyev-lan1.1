using System;
using System.Text.RegularExpressions;

namespace русланхы
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, y, t;
            Console.Write("Введите y");
            y = double.Parse(Console.ReadLine());
            Console.Write("Введите t:");
            t = double.Parse(Console.ReadLine());
            S = 4.351 * y * y * y + 2 * t *Math.Log(t) / Math.Sqrt(Math.Cos(2 * y + 4.351));
            
        }
    } 
}
