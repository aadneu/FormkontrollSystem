using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormkontrollSystem
{
    internal class Rectangle : Shape

    {
        protected double Length { get; set; }
        protected double Width { get; set; }

        public Rectangle(float length, float width, string name, string color) : base(name, color)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
          var areal = Length* Width;
          return areal;
        }

       
        public override void Show()
        {
            Console.WriteLine("***Rektangel***");
            Console.WriteLine($"Navn: {Name}, Farge: {Color}");
            Console.WriteLine($"Lengde: {Length}");
            Console.WriteLine($"Bredde: {Width}");
            Console.WriteLine("Formel: Lengde * Bredde");
            Console.WriteLine($"Areal: {CalculateArea()}\n");
        }
    
    }
}
