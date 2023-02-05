namespace Radiany
{
    internal class Program
    {
        static double StopnieNaRadiany(double stopnie)
        {
            return stopnie * double.Pi / 180;
        }

        static double RadianyNaStopnie(double radiany)
        {
            return radiany * 180 / double.Pi;
        }

        // rozwiązuje równanie ax^2 + bx + c = 0
        static (double, double) RownanieKwadratowe(double a, double b, double c)
        {
            var delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                var delta_sqrt = Math.Sqrt(delta);
                var x1 = (-b - delta_sqrt) / (2 * a);
                var x2 = (-b + delta_sqrt) / (2 * a);

                return (x1, x2);
            }
            else
            {
                return (double.NaN, double.NaN);
            }

            // to się nie wykona, martwy kod
            Console.WriteLine("trele morele");
        }

        static void Main(string[] args)
        {
            var stopnie = 90;

            // zamieniamy na radiany
            var radiany = StopnieNaRadiany(stopnie);

            Console.WriteLine(radiany);

            var zpowrotem90 = RadianyNaStopnie(radiany);
            Console.WriteLine(zpowrotem90);

            // x^2 - 3x + 2 = 0 
            var (r, mateusz) = RownanieKwadratowe(1, -3, 2);

            Console.WriteLine("x1 = {0}, x2 = {1}", r, mateusz);
        }
    }
}