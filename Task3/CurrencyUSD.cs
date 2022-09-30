using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class CurrencyUSD : Currency
    {
        public CurrencyUSD() { }
        public CurrencyUSD(double _Value) => Value = _Value;

        public double Convert_To_RUB() => Value * 55.3;
        public double Convert_To_EUR() => Value * 1.02;


        public static implicit operator CurrencyRUB(CurrencyUSD obj)
        {
            CurrencyRUB rubles = new CurrencyRUB();
            rubles.Value = obj.Convert_To_RUB();
            return rubles;
        }
        public static explicit operator CurrencyUSD(CurrencyRUB obj)
        {
            Value = obj.Convert_To_USD();
            CurrencyUSD dollars = new CurrencyUSD(Value);
            return dollars;
        }

        public static implicit operator CurrencyEUR(CurrencyUSD obj)
        {
            CurrencyEUR euro = new CurrencyEUR();
            euro.Value = obj.Convert_To_EUR();
            return euro;
        }
        public static explicit operator CurrencyUSD(CurrencyEUR obj)
        {
            Value = obj.Convert_To_USD();
            CurrencyUSD dollars = new CurrencyUSD(Value);
            return dollars;
        }

        static double Value;
    }
}
