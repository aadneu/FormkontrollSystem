using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormkontrollSystem
{
    internal class Triangle : Shape
    {
        protected double Grunnlinje { get; set; }
        protected double Height { get; set; }

        public Triangle(float grunnlinje, float height, string name, string color) : base(name, color)
        {
            Grunnlinje = grunnlinje;
            Height = height;
        }
        public override double CalculateArea()
        {
            var areal = Grunnlinje * Height / 2;
            //Trekanten har altså areal halvparten av grunnlinje ganger høyde: A=gh2.
            return areal;
        }

        public override void Show()
        {
            Console.WriteLine("***Trekant***");
            Console.WriteLine($"Navn: {Name}, Farge: {Color}");
            Console.WriteLine($"Grunnlinje: {Grunnlinje}");
            Console.WriteLine($"Høyde: {Height}");
            Console.WriteLine("Formel: Grunnlinje * Høyde / 2");
            Console.WriteLine($"Areal: {CalculateArea()}\n");
        }
    }
}
