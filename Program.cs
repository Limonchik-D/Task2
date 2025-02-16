using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine();

            Rectangle rectangle1 = new Rectangle(5, 10);
            Console.WriteLine(rectangle1.ToString());
            Console.WriteLine();

            Console.Write("Ввдите длину: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ввдите ширину: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle2 = new Rectangle(length, width);
            Console.WriteLine(rectangle2);
            Console.ReadLine();
        }
    }
}
