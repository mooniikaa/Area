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
            int num = int.Parse(Console.ReadLine());
            do
            {
            Console.WriteLine("1 Rectangle");
                Console.WriteLine("2 Circle");
            Console.WriteLine("3 Exit");

            Rectangle rectangle = new Rectangle();
                Circle circle = new Circle();
                
                         
                    if (num == 1)
                    {
                    Console.Write("A ");
                    rectangle.A = double.Parse(Console.ReadLine());
                    Console.Write("B ");
                    rectangle.B = double.Parse(Console.ReadLine());
                    Console.WriteLine("P = " + (rectangle.A + rectangle.B) * 2);
                    Console.WriteLine("S = " + rectangle.A * rectangle.B);
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
