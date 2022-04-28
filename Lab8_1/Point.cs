using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    public class Point
    {
        private int x;
        private int y;

        public Point() 
        { 
            this.x = 0; 
            this.y = 0; 
        }
        public Point(int x, int y) 
        { 
            this.x = x; 
            this.y = y; 
        }
        public Point(Point p) 
        { 
            this.x = p.x; 
            this.y = p.y; 
        }
        public int GetX() 
        { 
            return this.x; 
        }
        public int GetY() 
        { 
            return this.y; 
        }
        public void SetX(int value) 
        { 
            this.x = value; 
        }
        public void SetY(int value) 
        { 
            this.y = value; 
        }
        ~Point()
        {
            Console.WriteLine("Destructor Was Called");
        }
        public void Read()
        {
            Console.WriteLine("x: ");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y: ");
            this.y = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        { 
            return "Point[" + "x: " + this.x + " y: " + this.y + "]"; 
        }
    }
}
