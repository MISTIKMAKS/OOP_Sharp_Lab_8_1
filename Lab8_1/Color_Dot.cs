using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    public class Color_Dot : Point
    {
        private string color;
        public Color_Dot() 
        {
            this.SetX(0); 
            this.SetY(0);
            this.color = ""; 
        }
        public Color_Dot(int x, int y, string color) 
        {
            this.SetX(x);
            this.SetY(y);
            this.color = color; 
        }
        public Color_Dot(int x, string color)
        {
            this.SetX(x);
            this.SetY(0);
            this.color = color;
        }
        public Color_Dot(string color, int y)
        {
            this.SetX(0);
            this.SetY(y);
            this.color = color;
        }
        public Color_Dot(string color)
        {
            this.SetX(0);
            this.SetY(0);
            this.color = color;
        }
        public Color_Dot(int x, int y)
        {
            this.SetX(x);
            this.SetY(y);
            this.color = "";
        }
        public Color_Dot(Color_Dot c_d) 
        {
            this.SetX(c_d.GetX());
            this.SetY(c_d.GetY());
            this.color = c_d.color; 
        }
        public string GetColor() 
        { 
            return this.color; 
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
            this.SetX(x);
            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            this.SetY(y);
            Console.WriteLine("color: ");
            this.color = Console.ReadLine();
        }
        public override string ToString()
        { 
            return "Color_Dot[" + "point: " + "[x: " + this.GetX() + " y: " + this.GetY() + "]" + " color: " + this.color + "]"; 
        }
    }
}
