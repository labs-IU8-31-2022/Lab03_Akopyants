using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class CurrencyRUB : Currency
    {
        public CurrencyRUB() { }
        public CurrencyRUB(double _Value) => Value = _Value;

        public double Convert_To_USD() => Value * 0.018084;
        public double Convert_To_EUR() => Value * 0.018962;


        public static implicit operator CurrencyUSD(CurrencyRUB obj)
        {
            CurrencyUSD Dollar = new CurrencyUSD();
            Dollar.Value = obj.Convert_To_USD();
            return Dollar;
        }

        public static explicit operator CurrencyRUB(CurrencyUSD obj)
        {
            Value = obj.Convert_To_RUB();
            CurrencyRUB rubles = new CurrencyRUB(Value);
            return rubles;
        }


        public static implicit operator CurrencyEUR(CurrencyRUB obj)
        {
            CurrencyEUR euro = new CurrencyEUR();
            euro.Value = obj.Convert_To_EUR();
            return euro;
        }

        public static explicit operator CurrencyRUB(CurrencyEUR obj)
        {
            Value = obj.Convert_To_RUB();
            CurrencyRUB rubles = new CurrencyRUB(Value);
            return rubles;
        }

        static double Value;
    }
}
