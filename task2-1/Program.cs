Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());

int first = N / 10;
int second = first % 10;

Console.WriteLine(second);
