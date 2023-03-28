using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SClass
{
    public class Square
    {
        public double x1, y1, x2, y2, x3, y3, x4, y4;
        public double Yvalue, Xvalue, distance;
        public double Perimeter, Area;        
        public Square(double a1, double a2, double a3, double a4, double b1, double b2, double b3, double b4)
        {
            x1 = a1;
            y1 = b1;
            x2 = a2;
            y2 = b2;
            x3 = a3;
            y3 = b3;
            x4 = a4;
            y4 = b4;

            FormulaFirst();
            FormulaSecond();
        }
        public void FormulaFirst()
        {
            Xvalue = (x1 - x2);
            Yvalue = (y1 - y2);
            distance = (double)Math.Sqrt(Xvalue * Xvalue + Yvalue * Yvalue);
        }
        public void FormulaSecond()
        {
            Perimeter = distance * 4;
            Area = distance * distance;
        }
        //overloading
        // Square + double
        public static Square operator +(Square s, double d)
        {
            s.x1 += d;
            s.y1 += d;
            s.x2 += d;
            s.y2 += d;
            s.x3 += d;
            s.y3 += d;
            s.x4 += d;
            s.y4 += d;
            return s;
        }
        //double + Square
        public static Square operator +(double d, Square s)
        {
            return s + d;
        }
        //Square * Square
        public static Square operator *(Square s1, Square s2)
        {
            double minX = Math.Min(Math.Min(s2.x1, s2.x2), Math.Min(s2.x3, s2.x4));
            double minY = Math.Min(Math.Min(s2.y1, s2.y2), Math.Min(s2.y3, s2.y4));
            s1.x1 *= minX;
            s1.y1 *= minY;
            s1.x2 *= minX;
            s1.y2 *= minY;
            s1.x3 *= minX;
            s1.y3 *= minY;
            s1.x4 *= minX;
            s1.y4 *= minY;
            return s1;
        }
        //Square <= Square
        //public static bool operator <= (Square s1, Square s2)
        //{
        //    return s1.Perimeter <= s2.Perimeter;
        //}
        //Square++
        public static Square operator ++(Square s)
        {
            s.x1++;
            s.y1++;
            s.x2++;
            s.y2++;
            s.x3++;
            s.y3++;
            s.x4++;
            s.y4++;

            return s;
        }
        //!Square
        public static bool operator !(Square square)
        {
            double x1 = square.x1;
            double y1 = square.y1;
            double x2 = square.x2;
            double y2 = square.y2;
            double x3 = square.x3;
            double y3 = square.y3;
            double x4 = square.x4;
            double y4 = square.y4;

            double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            double d = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));

            double diagonal1 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double diagonal2 = Math.Sqrt(Math.Pow(x2 - x4, 2) + Math.Pow(y2 - y4, 2));

            if (a == b && b == c && c == d)
            {
                return true;
            }
            else if (diagonal1 == diagonal2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ~Square()
        {
            //destructor
        }
    }
}
