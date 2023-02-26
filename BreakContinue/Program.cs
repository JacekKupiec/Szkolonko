/* Przykład break i continue
 * for (int i = 0; i < 1000; i = i + 1)
{
    if (i == 3)
    {
        i = 5000;
        continue;
    }

    Console.WriteLine(i);
    if (i == 15)
    {
        break;
    }
}*/

using System.Runtime.CompilerServices;

var generator = new Random();
var liczba_do_zgadnięcia = generator.Next(20) + 1;

while (true)
{
    Console.Write("Podaj liczbę, którą wylosowano: ");
    var liczba = int.Parse(Console.ReadLine());

    if (liczba == liczba_do_zgadnięcia) break;

    if (liczba > liczba_do_zgadnięcia) Console.WriteLine("Spróbuj mniejszą liczbę");

    if (liczba < liczba_do_zgadnięcia) Console.WriteLine("Spróbuj większą liczbę");
}

Console.WriteLine("Gratuluję zgadłeś!");

int x = 5;
Console.WriteLine("{0} {1} {2}", ++x, x++, x);

int y = 5;
int z = y++ + 1; // y cały czas jest 5
// y jest 6

int w = 5;
int v = ++w + 1; // w jest już 6
// w jest 6

// W przypadku pętli nie ma znaczenia czy ++ lub -- jest z przodu czy z tyłu
for (int i = 0; i < 10; i++)
{

}