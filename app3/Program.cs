// inicjalizacja tabeli
int[] jacek = new int[] { 1, 56, -5, 12 };
int i = 0;

while (i < jacek.Length)
{
    Console.WriteLine("{0}: {1}", i, jacek[i]);
    i = i + 1;
}

i = 0;
int suma = 0;

while (i < jacek.Length)
{
    suma = suma + jacek[i];
    i = i + 1;
}

Console.WriteLine(suma);

do
{
    Console.WriteLine("Wykonam się przynajmniej raz");
} while (i < jacek.Length);

foreach (int element in jacek)
{
    Console.WriteLine(element);
}

/*while (true)
{
    Console.WriteLine("infinite loop");
}*/