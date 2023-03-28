using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SClass;

namespace Lab_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            double a1, b1, a2, b2, a3, b3, a4, b4;
            Console.WriteLine("This program finds the area and pirimeter of the square");
            Console.WriteLine("Press (y) to continue");
            choice = Console.ReadKey().KeyChar;
            while (choice == 'y')
            {
                Console.WriteLine("\nEnter the coordinates of the vertices of the square");
                Console.WriteLine("Enter first point:");
                a1 = double.Parse(Console.ReadLine());
                b1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second point:");
                a2 = double.Parse(Console.ReadLine());
                b2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter third point:");
                a3 = double.Parse(Console.ReadLine());
                b3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter fourth point:");
                a4 = double.Parse(Console.ReadLine());
                b4 = double.Parse(Console.ReadLine());

                
                Square mySquare = new Square(a1, a2, a3, a4, b1, b2, b3, b4);
                mySquare.FormulaFirst();
                mySquare.FormulaSecond();

                Console.WriteLine($"Length of a side of the square: {mySquare.distance}");
                Console.WriteLine($"Perimeter = {mySquare.Perimeter}");
                Console.WriteLine($"Area = {mySquare.Area}");
                Console.WriteLine();

                Console.WriteLine($"Operators Overloading:");
                
                double num = 2.5;
                Square newSquare = mySquare + num;
                Console.WriteLine($"\nAfter adding {num} to the coordinates of the square:");
                Console.WriteLine($"Length of a side of the square: {newSquare.distance}");
                Console.WriteLine($"Perimeter = {newSquare.Perimeter}");
                Console.WriteLine($"Area = {newSquare.Area}");

                 
                double num2 = 5.5;
                Square newSquare2 = num2 + mySquare;
                Console.WriteLine($"\nAfter adding the square to {num2}:");
                Console.WriteLine($"Length of a side of the square: {newSquare2.distance}");
                Console.WriteLine($"Perimeter = {newSquare2.Perimeter}");
                Console.WriteLine($"Area = {newSquare2.Area}");
                
                Square newSquare3 = mySquare * newSquare2;
                Console.WriteLine($"\nAfter multiplying the coordinates of two squares:");
                Console.WriteLine($"Length of a side of the square: {newSquare3.distance}");
                Console.WriteLine($"Perimeter = {newSquare3.Perimeter}");
                Console.WriteLine($"Area = {newSquare3.Area}");
                
                //Console.WriteLine($"\nIs the perimeter of the first square less than or equal to the perimeter of the second square?");
                //Console.WriteLine(mySquare <= newSquare2);

              
                Console.WriteLine("Increment coordinates of the vertices of the square:");
                mySquare++;
                Console.WriteLine($"New coordinates: ({mySquare.x1}, {mySquare.y1}), ({mySquare.x2}, {mySquare.y2}), ({mySquare.x3}, {mySquare.y3}), ({mySquare.x4}, {mySquare.y4})");


                Console.WriteLine($"!mySquare: {(!mySquare)}");

                Console.WriteLine("Repeat(y): ");
                choice = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nThe end");
        }
    }
}
    