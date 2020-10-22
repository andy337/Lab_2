using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб_2._1
{
    class TTrianglePrizm : TTriangle
    {
        private int h;

        public TTrianglePrizm(int a, int b, int c, int h) : base(a, b, c) 
        {
            this.h = h;
        }

        public TTrianglePrizm() { }

        public override string ToString() // вивід даних
        {
            return A + " " + B + " " + C + " " + h;
        }

        public int Volune() // об'єм призми
        {
            return Area() * h;
        }

        public new int Area() // площа призми

        {
            return 2 * base.Area() + Perumetr() * h;
        }

        public void Equality_of_triangles(TTrianglePrizm prizm)
        {
            if (Perumetr() + h == prizm.A + prizm.B + prizm.C + prizm.h)
            {
                Console.WriteLine("Призми рiвнi");
            }
            else
                Console.WriteLine("Призми не рiвнi");
        }


    }
}
