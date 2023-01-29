namespace FooBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] tbl1 = new[] { "Ala ma kota", "kot ma ale" };

            foreach (string text in tbl1)
            {
                Console.WriteLine(text);
            }*/

            for (int i = 1; i <= 200; i = i + 1)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} foobar", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} foo", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0} bar", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}