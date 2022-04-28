using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    public class Geometrical_Dot : Point
    {
        private Point point;
        private char name;
        public Geometrical_Dot()
        {
            this.point = new Point();
            this.name = '\0';
        }
        public Geometrical_Dot(int x, int y, char name)
        {
            this.point = new Point(x, y);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(int x, char name)
        {
            this.point = new Point(x, 0);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(char name, int y)
        {
            this.point = new Point(0, y);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(char name)
        {
            this.point = new Point(0, 0);
            this.name = Char.ToUpper(name);
        }
        public Geometrical_Dot(int x, int y)
        {
            this.point = new Point(x, y);
            this.name = ' ';
        }
        public Geometrical_Dot(Geometrical_Dot c_d)
        {
            this.point = c_d.point;
            this.name = Char.ToUpper(c_d.name);
        }
        public Point GetPoint()
        {
            return this.point;
        }
        public char GetName()
        {
            return Char.ToUpper(this.name);
        }
        public void SetPoint(Point value)
        {
            this.point = value;
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
            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            this.point = new Point(x, y);
            Console.WriteLine("name: ");
            this.name = Char.ToUpper(Console.ReadKey().KeyChar);
        }
        public override string ToString()
        {
            return "Geometrical_Dot[" + "point: " + this.point + " name: " + this.name + "]";
        }
    }
}
