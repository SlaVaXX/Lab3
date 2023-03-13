using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Vector
    {
        public static Vector operator /(Vector v, double value)
        {
            return new Vector(v.angle, v.length / value);
        }
        public static double operator /(double value, Vector v)
        {
            return Math.Round(value / v.length,2);
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1.length > v2.length)
            {
                return new Vector(v1.coordinates.X);
            }
            else return new Vector(v2.coordinates.X);
        }
        public static bool operator >(Vector v1, Vector v2)
        {
            return v1.length > v2.length;
        }
        public static bool operator <(Vector v1, Vector v2)
        {
            return v1.length < v2.length;
        }
        public static Vector operator --(Vector v)
        {
            v.coordinates.X = (float)Math.Round(v.coordinates.X - 1,2);
            v.coordinates.Y = (float)Math.Round(v.coordinates.Y - 1,2);
            v.length = v.SetLength(v.angle, v.coordinates);
            return v;
        }
        public static bool operator !(Vector v)
        {
            if (v.coordinates.X != 0 || v.coordinates.Y != 0)
                return false;
            else return true;
        }



        private double angle;
        private double length;
        private Vector2 coordinates;
        public Vector(double angle, double length)
        {
            this.angle = angle;
            if (length < 0)
                length = Math.Abs(length);
            this.length = Math.Round(length,2);
            coordinates = setCoordinates(angle, length);
        }
        public Vector(double length)
        {
            if (length < 0)
                length = Math.Abs(length);
            this.length = Math.Round(length,2);
            coordinates = setCoordinates(0, length);
        }
        public Vector()
        {
            
        }
        public Vector2 setCoordinates(double angle, double length)//обчислення координат вектора на основі його довжини та кута
        {
            double x = Math.Round(length * Math.Cos(angle), 2);
            double y = Math.Round(length * Math.Sin(angle), 2);
            Vector2 result = new Vector2((float)x, (float)y);
            return result;
        }
        private double SetLength(double angle, Vector2 coordinates)
        {
            return Math.Round(Math.Sqrt(coordinates.X * coordinates.X + coordinates.Y * coordinates.Y), 2);
        }
        public Vector2 getCoordinates
        {
            get { return coordinates; }
        }
        public void vectorData()
        {
            Console.WriteLine($"\nКоординати вектора: {coordinates}\nКут вектора: {angle}\nДовжина вектора: {length}");
        }
        public void changeCoordinates(Vector2 newCoordinates)
        {
            coordinates.X = newCoordinates.X;
            coordinates.Y = newCoordinates.Y;
        }
    }
}
