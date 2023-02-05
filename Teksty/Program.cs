namespace Teksty
{
    internal class Program
    {
        /* 
         * byte (0 - 255), sbyte (-128, 127)
         * short int, short uint 2 bajty
         * int, uint 4 bajty
         * long, ulong 8 bajtów
         * float (4 bajty), double (8 bajtów)
         * decimal 12 bajtów
         * char 2 bajty przechowuje kody znaków
         * string char[]
         */

        static void Main(string[] args)
        {
            Console.WriteLine("ABBA"); // { 'A', 'B', 'B', 'A', 0 }
            string tekst1 = "Ala ma kota"; // "A", 'A'
            char[] tekst2 = new char[] { 'A', 'J' }; // "AJ" => {'A', 'J', 0}

            var text_result = tekst1 + "qwerty"; // => "Alamakotaqwerty"

            foreach (char c in text_result) {
                Console.WriteLine(c);
            }

            var inny_tekst = "1, 2, 3, 4, 5, 6";
            var tabelka = new int[6];
            var podzielony_tekst = inny_tekst.Split(", ");

            int idx = 0;

            foreach (string tekst_po_podzieleniu in podzielony_tekst) 
            {
                tabelka[idx] = int.Parse(tekst_po_podzieleniu);
                idx = idx + 1;
            }

            for (int i = 0; i < podzielony_tekst.Length; i = i + 1) 
            {
                tabelka[i] = int.Parse(podzielony_tekst[i]);
            }
        }
    }
}