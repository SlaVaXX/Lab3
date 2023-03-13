using System.Drawing;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Vector v1 = new Vector(45, 5);
            Vector v2 = new Vector(60, 3);
            //1)Vector / double

            //v1.vectorData();
            //v1 /= 2.34;
            //v1.vectorData();

            //2)double / Vector

            //double example = 5.5;
            //example /= v1;

            //3)Vector + Vector

            //Vector v3 = v1 + v2;
            //v3.vectorData();

            //4)Vector > Vector

            //bool rez1 = v1 > v2;
            //bool rez2 = v1 < v2;

            //5)Vector--

            //v1.vectorData();
            //v1--;
            //v1.vectorData();

            //6)!Vector

            //Vector v3 = new Vector(0);
            //bool rez1 = !v1;
            //bool rez2 = !v2;
            //bool rez3 = !v3;
        }
    }
}
