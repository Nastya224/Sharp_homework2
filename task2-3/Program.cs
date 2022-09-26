int Monday = 1;
int Tuesday = 2;
int Wensday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;

Console.Write("Введите число от 1 до 7 (включительно):");
int N = int.Parse(Console.ReadLine());

if (N<=7) 
{
    if (N<5)
    {
        Console.Write(N);
    Console.WriteLine("-> нет");
    }
    else 
    {
    Console.Write(N);
    Console.WriteLine("-> да");
    }
}
