using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    public class Color_Dot : Point
    {
        private Point point;
        private string color;
        public Color_Dot() 
        { 
            this.point = new Point(); 
            this.color = ""; 
        }
        public Color_Dot(int x, int y, string color) 
        { 
            this.point = new Point(x, y); 
            this.color = color; 
        }
        public Color_Dot(int x, string color)
        {
            this.point = new Point(x, 0);
            this.color = color;
        }
        public Color_Dot(string color, int y)
        {
            this.point = new Point(0, y);
            this.color = color;
        }
        public Color_Dot(string color)
        {
            this.point = new Point(0, 0);
            this.color = color;
        }
        public Color_Dot(int x, int y)
        {
            this.point = new Point(x, y);
            this.color = "";
        }
        public Color_Dot(Color_Dot c_d) 
        { 
            this.point = c_d.point; 
            this.color = c_d.color; 
        }
        public Point GetPoint() 
        { 
            return this.point; 
        }
        public string GetColor() 
        { 
            return this.color; 
        }
        public void SetPoint(Point value) 
        { 
            this.point = value; 
        }
        public void SetColor(string value) 
        { 
            this.color = value; 
        }
        ~Color_Dot() 
        {
            Console.WriteLine("Destructor Was Called");
        }
        public void Read()
        {
            Console.WriteLine("point: ");
            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            this.point = new Point(x, y);
            Console.WriteLine("color: ");
            this.color = Console.ReadLine();
        }
        public override string ToString()
        { 
            return "Color_Dot[" + "point: " + this.point + " color: " + this.color + "]"; 
        }
    }
}
