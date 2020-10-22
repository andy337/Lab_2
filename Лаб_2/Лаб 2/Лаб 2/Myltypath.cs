using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб_2
{
    class Multypath
    {
        protected double[] len;
        protected double[,] dot;

        public Multypath() // конструктор для ввода даних
        {
            int n = int.Parse(Console.ReadLine()); // рядки
            int m = int.Parse(Console.ReadLine()); // стовпчики
            dot = new double[n, m];
            len = new double[dot.GetLength(0)];

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(" ");
                for (int j = 0; j < m; j++)
                {
                    double num = Convert.ToDouble(str[j]);
                    dot[i, j] = num;
                }
            }
            Len();
        }

        public Multypath(double [,] dots) // конструктор
        {

            len = new double[dots.GetLength(0)];
            dot = dots;
            Len();
        }

        private void Len()
        {
            double Sum = 0;
            for (int i = 0; i < dot.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Sum += Math.Pow(dot[(i + 1) % dot.GetLength(0), j] - dot[i % dot.GetLength(0), j], 2);
                }
                len[i] = Math.Sqrt(Sum);
                Sum = 0;
            }
        }

        public void Print() // Вивід 
        {
            foreach(double item in len)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public double Perumetr() // Периметр
        {
            double Sum = 0;
            foreach(double item in len)
            {
                Sum += item;
            }
            return Sum;
        }

        public double Area() // Площа многокутника
        {
            double Sum2 = 0;
            double Sum1= 0;
            int temp = 1;
            for (int i = 0; i <= 1; i++)
            {
                Sum2 = Sum1;
                Sum1 = 0;
                for (int j = 0; j < dot.GetLength(0); j++)
                {
                    Sum1 += dot[j % dot.GetLength(0), i] * dot[(j + 1) % dot.GetLength(0), i + temp];
                }
                temp = -1;
            }
            return (Sum2 - Sum1) / 2;
        }

        public double this[int index]
        {
            get
            {
                return len[index];
            }

            set
            {
                if (index >= 0 && index < len.Length)
                {
                    len[index] = value;
                }
            }
        }
    }
}
