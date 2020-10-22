
using System;

namespace Лаб_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] array = new double[,] { {-3, -2}, {-1, 4}, {6, 1}, {3 , 10}, {-4, 9} };
            Multypath dot = new Multypath(array);
            dot.Print();
            Console.WriteLine(dot.Perumetr());
            Console.WriteLine(dot.Area());

        }
    }
}
