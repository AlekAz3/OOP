using System;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(-1, 3);
            Point point2 = new Point(6, 2);

            Console.WriteLine(point1.FindDistance(point2));
        }
    }
}
