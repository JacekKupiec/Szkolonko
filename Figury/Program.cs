namespace Figury
{
    /*
     * Napisz program/programy, które wyliczają pola różnych figur. Możesz umieścić kilka wzorów w jednym programie. Proponuję:
        ◦ Kwadrat
        ◦ Prostokąt
        ◦ Rąb
        ◦ Równoległobok
        ◦ Trójkąt
        ◦ Koło
    */
    internal class Program
    {
        static int PoleKwadratu(int bok)
        {
            return bok * bok;
        }

        static int PoleProstokata(int a, int b)
        {
            return a * b;
        }

        static double PoleTrojkata(double a = 7, double h = 1)
        {
            return a * h / 2;
        }

        static double PoleTrojkata(double a, double b, double c, double R)
        {
            return a * b * c / 4 / R;
        }

        /*static double PoleTrojkata(double p = 3, double r = 5)
        {
            return p * r;
        }*/

        static void Main(string[] args)
        {
            Console.Write("Podaj nazwę figury: ");
            var nazwaFigury = Console.ReadLine();

            switch (nazwaFigury)
            {
                case "kwadrat":
                    Console.Write("Podaj bok kwadratu: ");
                    var bokKwadratu = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole kwadratu wynosi: {PoleKwadratu(bokKwadratu)}");
                    break;
                case "prostokąt":
                    Console.Write("Podaj bok prostokąta: ");
                    var bokProstokata1 = int.Parse(Console.ReadLine());
                    Console.Write("Podaj drugi bok prostokąta: ");
                    var bokProstokata2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole prostokąta wynosi: {PoleProstokata(bokProstokata1, bokProstokata2)}");
                    break;
                case "trójkąt":
                    Console.Write("Podaj podstawę trójkąta: ");
                    var podstawaTrójkąta = double.Parse(Console.ReadLine());
                    Console.Write("Podaj drugi bok prostokąta: ");
                    var wysokośćTrójkąta = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Pole prostokąta wynosi: {PoleTrojkata(podstawaTrójkąta, wysokośćTrójkąta)}");
                    break;
                default: 
                    Console.WriteLine($"Podałeś niewłaściwą opcję. Polczę domyślne pole trójkąta: {PoleTrojkata()}");
                    break;
            }

            if (nazwaFigury == "kwadrat")
            {
                //
            } 
            else 
                if (nazwaFigury == "prostokąt")
                {
                    // 
                }
                else 
                    if (nazwaFigury == "trójkąt")
                    {
                        //
                    }
                    else
                    {

                    }

            /* 1 instrukcja przy if'ie nie wymaga klamerek
            if (warunek)
                //
            else
                //*/
                
        }
    }
}