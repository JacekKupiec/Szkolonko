// See https://aka.ms/new-console-template for more information

ulong SilniaRek(ulong n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * SilniaRek(n - 1);
    }
}


// tak nie robimy
ulong x(ulong n)
{
    return x(n);
}

ulong SilniaIter(ulong n)
{
    ulong silnia_wynik = 1;

    for (ulong i = 1; i <= n; i = i + 1)
    {
        silnia_wynik = silnia_wynik * i;
    }

    return silnia_wynik;
}

Console.WriteLine("{0}\n{1}\n{2}\n", SilniaRek(20), SilniaRek(25), ulong.MaxValue);

Console.WriteLine("{0}\n{1}\n{2}", SilniaIter(20), SilniaIter(25), ulong.MaxValue);


ulong FibonacciRek(ulong n)
{
    if (n == 0)
    {
        return 0;
    } 
    else if (n == 1)
    {
        return 1;
    } 
    else
    {
        return FibonacciRek(n - 1) + FibonacciRek(n - 2);
    }
}

ulong FibonacciIter(ulong n)
{
    if (n == 0)
    {
        return 0;
    }

    if (n == 1)
    {
        return 1;
    }

    ulong f1 = 0, f2 = 1, f = 0;

    for (ulong i = 1; i <= n; i = i + 1)
    {
        f = f1 + f2;
        f2 = f1;
        f1 = f;
    }

    return f;
}

Console.WriteLine("{0}, {1}, {2}", FibonacciRek(0), FibonacciRek(1), FibonacciRek(17));

Console.WriteLine("{0}, {1}, {2}", FibonacciIter(0), FibonacciIter(1), FibonacciIter(17));