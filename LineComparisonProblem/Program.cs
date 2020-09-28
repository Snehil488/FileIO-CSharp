using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation.");

            int x1, x2, y1, y2, x3, y3, x4, y4;

            Console.WriteLine("Enter values x1 and y1 for Line 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 1");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values x1 and y1 for Line 2");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 2");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            double len1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double len2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));


            int diffInLength = len1.CompareTo(len2);

            if (diffInLength == 0)
                Console.WriteLine("Lines are equal in length");
            else if (diffInLength > 0)
                Console.WriteLine("Line1 is greater in length than Line2");
            else
                Console.WriteLine("Line1 is smaller in length than Line2");




        }
    }
}
