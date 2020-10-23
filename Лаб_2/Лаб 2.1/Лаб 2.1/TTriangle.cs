using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб_2._1
{
    class TTriangle
    {
        private int a;
        private int b;
        private int c;

        public int A { get { return a; } }

        public int B { get { return b; } }

        public int C { get { return c; } }

        public TTriangle() { } // конструктор без параметрів

        public TTriangle(int a, int b, int c) // конструктор
        {
            if(a < b + c && b < a + c && c < a + b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Такого трикутника не iснує");
                Environment.Exit(0);
            }
        }

        public TTriangle(TTriangle tr) : this(tr.a, tr.b, tr.c) { } // копіюючий конструктор

        public override string ToString() // вивід даних
        {
            return a + " " + b + " " + c;
        }

        public int Perumetr() // периметр
        {
            return a + b + c;
        }

        private int Perumetr(TTriangle triangle) 
        {
            return triangle.a + triangle.b + triangle.c;
        }

        public int Area()
        {
            int p = (a + b + c) / 2;
            int S = Math.Abs(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        public void Equality_of_triangles(TTriangle triangle)
        {
            if(Perumetr() == Perumetr(triangle))
            {
                Console.WriteLine("Трикутники рвіні");
            }
            else
            Console.WriteLine("Трикутники не рвіні");
        }
        
        public static TTriangle operator *(TTriangle tr, int num)
        {
            return new TTriangle { a = tr.a * num, b = tr.b * num, c = tr.c * num };
        }

        public static TTriangle operator *(int num, TTriangle tr)
        {
            return new TTriangle { a = tr.a * num, b = tr.b * num, c = tr.c * num };
        }
    }
}
