int n = int.Parse(Console.ReadLine());
Console.Write($"{n}->");
for (int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}