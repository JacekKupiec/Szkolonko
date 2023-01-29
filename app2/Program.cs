/*
= przypisanie wartości do zmiennej
+ dodawanie
- odejmowanie
* mnożenie
/ dzielenia
% reszta z dzielenia
== równe
!= różne
>, < 
>= <=
&& logiczne "i"
|| logiczne "lub"
! negacja
*/

const int abc = 42; // stałej nie można nadpisać
int z = 4; // wartość zmiennej można modyfikować;
bool warunek = abc > z; // wynik porównań możemy zapisać do zmiennej typu bool (prawda/fałsz)

// przykłady instrucko IF

if (z % 2 == 0 && z <= 5 && z != 1) 
{
    int h = 5; // ta zmienna żyje tylko w klamerkach

    Console.WriteLine("42 jest większe od {0}", z);
}

if (z % 2 == 1 || z <= 5 && z != 4) 
{
    Console.WriteLine("42 jest większe od {0}", z);
} 
else 
{
    Console.WriteLine("Warunek nie jest spełniony");
}

if (z % 2 == 1 || z <= 5 || z != 4) 
{
    Console.WriteLine("42 jest większe od {0}", z);
} 
else if (warunek) 
{

}
else if (warunek) 
{

}
else // else wcale nie musi być na końcu
{
    Console.WriteLine("Warunek nie jest spełniony");
}

// tworzenie nowej tabeli, wartości niezainicjalizowane
int[] t = new int[10];

t[0] = 7; // [rzypisywanie wartości do komórek tabeli

int[] jacek = new int[] { 1, 56, -5, 12 };

for (int i = 0; i < jacek.Length; i = i + 1) 
{
    Console.WriteLine("{0}: {1}", i, jacek[i]);
}

int suma = 0;

for (int i = 0; i < jacek.Length; i = i + 1) 
{
    suma = suma + jacek[i];
}

Console.WriteLine("{0}", suma);