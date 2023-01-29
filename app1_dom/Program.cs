//string input = Console.ReadLine();
var liczba = 3; //double.Parse(input);
double wynik = Math.Pow(liczba, 5);

Console.WriteLine("{0}", wynik);
Console.WriteLine("{0}", Math.Pow(liczba, 5));

// var a = wynik / 0;
// var b = 7 / 0;

Console.WriteLine("{0} {1}", wynik / 0, 0.0/0.0);

var x = 3.14f; // float
var y = 3.14; // double

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

Console.WriteLine("{0}", m / n);