Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());

if (N < 1000000)
{
    if (N >= 100000)
{
    int third = N / 1000 % 10;
    Console.WriteLine(third);
}
}

if (N < 100000)
{
    if (N >= 10000)
{
    int third = N / 100 % 10;
    Console.WriteLine(third);
}
}

if (N < 10000)
{
    if (N >= 1000)
{
    int third = N /10 % 10;
    Console.WriteLine(third);
}
}

if (N < 1000)
{
    if (N >= 100)
{
    int third = N % 10;
    Console.WriteLine(third);
}
}

if (N < 100) 
{
Console.WriteLine("третьей цифры нет");
}


