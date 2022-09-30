using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Car : IEquatable<Car>
    {
        public Car()
        {

        }

        public Car(string _name, string _engine, int _max_speed)
        {
            Name = _name;
            Engine = _engine;
            Max_Speed = _max_speed;
        }

        public override string ToString() => Name;
      
        public void equall(Car second)
        {
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine($"first car name - {Name} \t\t\t second car name - {second.Name}\nfirst car Engine - {Engine} \t\t\t " +
                $"second car engine - {second.Engine}\nfirst car max speed - {Max_Speed} \t\t second car max speed - {second.Max_Speed} ");
            Console.WriteLine("____________________________________________________________________");
        }

        public string Name { get; set; }
        public string Engine { get; set; }
        public int Max_Speed { get; set; }

      
        
    }
}