using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class CurrencyEUR : Currency
    {
        public CurrencyEUR() { }
        public CurrencyEUR(double _Value) => Value = _Value;


        public double Convert_To_USD() => Value * 0.9789;
        public double Convert_To_RUB() => Value * 52.74;

        public static implicit operator CurrencyRUB(CurrencyEUR obj)
        {
            CurrencyRUB rubles = new CurrencyRUB();
            rubles.Value = obj.Convert_To_RUB();
            return rubles;
        }

        public static explicit operator CurrencyEUR(CurrencyRUB obj)
        {
            Value = obj.Convert_To_EUR();
            CurrencyEUR euro = new CurrencyEUR(Value);
            return euro;
        }


        public static implicit operator CurrencyUSD(CurrencyEUR obj)
        {
            CurrencyUSD dollar = new CurrencyUSD();
            dollar.Value = obj.Convert_To_USD();
            return dollar;
        }

        public static explicit operator CurrencyEUR(CurrencyUSD obj)
        {
            Value = obj.Convert_To_EUR();
            CurrencyEUR euro = new CurrencyEUR(Value);
            return euro;
        }


        static double Value;
    }
}
