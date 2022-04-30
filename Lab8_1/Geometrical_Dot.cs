using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    public class Geometrical_Dot : Point
    {
        private char name;
        public Geometrical_Dot()
        {
            this.SetX(0);
            this.SetY(0);
            this.name = '\0';
        }
        public Geometrical_Dot(int x, int y, char name)
        {
            this.SetX(x);
            this.SetY(y);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(int x, char name)
        {
            this.SetX(x);
            this.SetY(0);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(char name, int y)
        {
            this.SetX(0);
            this.SetY(y);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(char name)
        {
            this.SetX(0);
            this.SetY(0);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(int x, int y)
        {
            this.SetX(x);
            this.SetY(y);
            this.name = ' ';
        }
        public Geometrical_Dot(Geometrical_Dot c_d)
        {
            this.SetX(c_d.GetX());
            this.SetY(c_d.GetY());
            this.name = Char.ToUpper(c_d.name);
        }
        public char GetName()
        {
            return Char.ToUpper(this.name);
        }
        public void SetName(char value)
        {
            this.name = Char.ToUpper(value);
        }
        ~Geometrical_Dot()
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
            Console.WriteLine("name: ");
            this.name = Char.ToUpper(Console.ReadKey().KeyChar);
        }
        public override string ToString()
        {
            return "Geometrical_Dot[" + "point: " + "[x: " + this.GetX() + " y: " + this.GetY() + "]" + " name: " + this.name + "]";
        }
    }
}
