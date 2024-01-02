
namespace FormkontrollSystem
{
    internal class Circle : Shape
    {
        protected float Radius { get; set; }

        public Circle(float radius, string name, string color) : base (name, color )
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            var areal = (Radius * Radius) * Math.PI;
            return areal;
        }

        public override void Show()
        {
            Console.WriteLine("***Sirkel***");
            Console.WriteLine($"Navn: {Name}, Farge: {Color}");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine("Formel: π * Radius^2");
            Console.WriteLine($"Areal: {CalculateArea()}\n");
        }
    }
}
