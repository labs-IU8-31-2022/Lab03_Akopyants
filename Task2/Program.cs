using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("honda", "jz1", 240);
            Car c2 = new Car("mazda", "jz2", 260);

            c1.equall(c2);

            Cars_Catalog catal = new Cars_Catalog(c1);

            catal.Add(c2);

            String test = catal[1];
            Console.WriteLine(test);
        }
    }
}
