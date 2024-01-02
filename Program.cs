namespace FormkontrollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var sirkel = new Circle(2);
            var rektangel = new Rectangle(2, 3);
            var trekant = new Triangle(2,3);

            sirkel.Show();
            rektangel.Show();
            trekant.Show();
            */
            
            var FormListe = new List<Shape>();
            FormListe.AddRange(new List<Shape>()
            {
                new Rectangle(42, 23, "Rektangel 1", "Brun"),
                new Rectangle(12, 32, "Rektangel 2", "Svart"),
                new Circle(54, "Sirkel 1", "Gul"),
                new Circle(23, "Sirkel 2", "Rød"),
                new Triangle(11,43, "Trekant 1", "Brun"),
                new Triangle(22, 14,"Trekant 2", "Rød"),
            });

           
            void CalculateTotalArea()
            {
                double TotalArea = 0;
                for (int i = 0; i < FormListe.Count; i++)
                {
                    TotalArea += FormListe[i].CalculateArea();
                }

                Console.WriteLine(TotalArea);
               
            }
            
            void SortFromLowToHigh()
            {
                List<Shape> SortertListe = FormListe.OrderBy(area => area.CalculateArea()).ToList();
                Console.WriteLine("*** SORTERT ETTER STØRRELSE PÅ AREAL ***");
                foreach (var shape in SortertListe)
                {
                    shape.Show();
                }
            }

           void FargeFiltrering(string farge)
            {
                for (int i = 0; i < FormListe.Count; i++)
                {
                    if (FormListe[i].Color.ToLower() == farge)
                    { 
                        FormListe[i].Show();
                    }
                }
            }

           Console.Write("Skriv inn en farge: ");
           var ColorInput = Console.ReadLine().ToLower();



           FargeFiltrering(ColorInput);

            // SortFromLowToHigh();
            // CalculateTotalArea();
        }
    }
}
