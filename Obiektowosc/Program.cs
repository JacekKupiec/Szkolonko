namespace Obiektowosc
{
    internal class Program
    {
        struct Wektor
        {
            public double x, y;

            public double Dlugosc()
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        class GospodarzKlasy : Uczen
        {

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
            protected double srednica;
            private int Klasa;

            public static byte liczbaKotow = 5;

            public virtual void Donies(string imieNauczyciela)
            {
                if (srednica < 17 && liczbaKotow > 5)
                {
                    Console.WriteLine($"Proszę pani!!! {imieNauczyciela}");
                    Nazwisko += "-Konfident";
                    Klasa = 30;
                }
            }

            public static int SredniaOcen(string imieNauczyciela)
            {
                return (liczbaKotow*Klasa + imieNauczyciela.GetHashCode()) % 6 + 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var v1 = new Wektor();
            v1.x = 4;
            v1.y = 5;

            var v2 = new Wektor
            {
                x = 4,
                y = 5
            };

            Console.WriteLine(v1.Dlugosc());

            var imieUczen1 = "Jacek";
            var nazwiskoUczen1 = "Kupiec";
            var dataUrodzeniaUczen1 = new DateOnly(1994, 6, 26);

            var imionaUczniow = new string[5];
            var datyUrodzinUczniow = new DateOnly[5];

            var uczenObiektPusty = (Uczen)null;

            Uczen.liczbaKotow = 7; // dostęp do statycznego pola, anty-pattern, nie robić tak

            // uczenObiektPusty.Imie - rzuca wyjątek NullReferenceException

            var uczenObiekt = new Uczen();
            uczenObiekt.DataUrodzenia.AddDays(1);
        }
    }
}