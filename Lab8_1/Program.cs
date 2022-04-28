using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            Console.WriteLine("Point a: " + a.ToString());
            Console.WriteLine("-------------------------");
            Color_Dot b = new Color_Dot(3, 5, "blue");
            Console.WriteLine("Color_Dot b: " + b.ToString());
            Console.WriteLine("Color_Dot b (Change): ");
            b.Read();
            Console.WriteLine("Color_Dot b (Changed): " + b.ToString());
            Console.WriteLine("-------------------------");
            Geometrical_Dot c = new Geometrical_Dot(2, 'c');
            Console.WriteLine("Geometrical_Dot c: " + c.ToString());
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}
