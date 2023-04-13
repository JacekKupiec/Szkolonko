namespace Obiektowosc
{
    internal class Program
    {
        struct Wektor
        {
            public double x, y;
        }

        class Uczen
        {
            // Konstrultor bezparametrowy, jeśli nie napiszesz swojego to on już jest napisany
            public Uczen()
            {
                Imie = "Jacek";
                Nazwisko = "Placek";
                DataUrodzenia = new DateOnly(1994, 6, 26);
            }

            // Konstruktor
            public Uczen(string imie, string nazwisko, DateOnly dataUrodzenia)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                DataUrodzenia = dataUrodzenia;
            }

            /*To co generuje kompilator
             * public Uczen()
            {
                Imie = default;
                Nazwisko = default;
                DataUrodzenia = default;
            }*/

            public string Imie;
            public string Nazwisko;
            public DateOnly DataUrodzenia;
            int Klasa;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var imieUczen1 = "Jacek";
            var nazwiskoUczen1 = "Kupiec";
            var dataUrodzeniaUczen1 = new DateOnly(1994, 6, 26);

            var imionaUczniow = new string[5];
            var datyUrodzinUczniow = new DateOnly[5];

            var uczenObiektPusty = (Uczen)null;

            // uczenObiektPusty.Imie - rzuca wyjątek NullReferenceException

            var uczenObiekt = new Uczen();
            uczenObiekt.
        }
    }
}