using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03_Akopyants
{
    class Vector
    {

        public Vector(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public static Vector operator+ (Vector first, Vector second)
        {
            double new_X = first.x + second.x;
            double new_Y = first.y + second.y;
            double new_Z = first.z + second.z;
            Vector result = new Vector(new_X, new_Y, new_Z);
            return result;
        }

        public static Vector operator*(Vector first, Vector second) // вектор на вектор
        {
            double new_X = first.x * second.x;
            double new_Y = first.y * second.y;
            double new_Z = first.z * second.z;
            Vector result = new Vector(new_X, new_Y, new_Z);
            return result;
        }

        public static Vector operator *(Vector first, double second) // вектор на число
        {
            double new_X = first.x * second;
            double new_Y = first.y * second;
            double new_Z = first.z * second;
            Vector result = new Vector(new_X, new_Y, new_Z);
            return result;
        }

        public static Vector operator *(double second, Vector first) // число на вектор 
        {
            double new_X = first.x * second;
            double new_Y = first.y * second;
            double new_Z = first.z * second;
            Vector result = new Vector(new_X, new_Y, new_Z);
            return result;
        }

        public static bool operator <(Vector first, Vector second ) //сравнение меньше 
        {
            double size_first = Math.Sqrt(Math.Pow(first.x, 2) + Math.Pow(first.y, 2) + Math.Pow(first.z, 2));
            double size_second = Math.Sqrt(Math.Pow(second.x, 2) + Math.Pow(second.y, 2) + Math.Pow(second.z, 2));
            if (size_first < size_second) return true;
            else return false;
        }
        public static bool operator >(Vector first, Vector second) // сравнение больше 
        {
            return second < first;
        }

        public override string ToString()
        {
            string result = " " +Convert.ToString(x);
            result += " " + Convert.ToString(y);
            result += " " + Convert.ToString(z);
            return result;
        }
        readonly double x;
        readonly double y;
        readonly double z;


    }
}
