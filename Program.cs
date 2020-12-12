using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
            Console.WriteLine("1 Rectangle");
                Console.WriteLine("2 Circle");
            Console.WriteLine("3 Exit");

            rectangle Rectangle = new rectangle();
                Circle circle = new Circle();
                num = int.Parse(Console.ReadLine());
                         
                    if (num == 1)
                    {
                    Console.Write("A ");
                    Rectangle.A = double.Parse(Console.ReadLine());
                    Console.Write("B ");
                    Rectangle.B = double.Parse(Console.ReadLine());
                    Console.WriteLine("P = " + (Rectangle.A + Rectangle.B) * 2);
                    Console.WriteLine("S = " + Rectangle.A * Rectangle.B);
                }
                if (num == 2)
                {
                    Console.Write("P ");
                    circle.P = double.Parse(Console.ReadLine());
                    Console.Write("R ");
                    circle.R = Math.PI;
                    Console.WriteLine("S = " + circle.P * circle.R * circle.R);
                }

            }
            while (num != 3);
            
        }
    }
}
