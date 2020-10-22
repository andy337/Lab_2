using System;

namespace Лаб_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle tr = new TTriangle(3, 4, 5);
            TTrianglePrizm trh = new TTrianglePrizm(3, 4, 5, 6);
            TTrianglePrizm trh1 = new TTrianglePrizm(3, 5, 4, 6);
            trh.Equality_of_triangles(trh1);

        }
    }
}
