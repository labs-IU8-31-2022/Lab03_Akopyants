using System;

namespace Lab03_Akopyants
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 4, 5);
            Vector v2 = new Vector(1, 4, 7);
            double value = 15;

            Console.WriteLine(v1 + v2);
            Console.WriteLine(v1 * v2);
            Console.WriteLine(v1 < v2);
            Console.WriteLine(v1 * value);

        }
    }
}
