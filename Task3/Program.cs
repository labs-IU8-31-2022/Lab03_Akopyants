using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyRUB rubles = new CurrencyRUB(1000);
            CurrencyUSD dollars = rubles;

            Console.WriteLine(dollars.Value);
        
        }
    }
}
