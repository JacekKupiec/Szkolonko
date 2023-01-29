// See https://aka.ms/new-console-template for more information
// zupa pomindorowa, dzielenie przez 0, Zielonka
Console.WriteLine("Hello, World!");

//Console.Clear();
int x = 4;
int y = 5;
int mateusz = -17;
uint jacek = 25;

// byte/sbyte - 1 bajt
// short/ushort - 2 bajty
// int/uint - 4 bajty
// long/ulong - 8 bajtów
// bool - prawda/fałsz

bool bbQ = false;

Console.WriteLine("{0} {1}", x, y);
Console.WriteLine("{0} {0}", 7, 11);
x = 15;
Console.WriteLine("{0} {1}", 4 + 5, x + y);

string liczba1 = Console.ReadLine();
string liczba2 = Console.ReadLine();

Console.WriteLine("{0}", liczba1 + liczba2);

x = int.Parse(liczba1);
y = int.Parse(liczba2);

int suma = x + y;
Console.WriteLine("{0} {1}", suma, x + y);

float q = 3.14f;
double m = 1.41;

Console.WriteLine("{0} {1}", sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("{0} {1}", uint.MinValue, uint.MaxValue);