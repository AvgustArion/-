Console.Clear();
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
a = max;
if (a > b)
{
    max = a;
    Console.WriteLine($"Наибольшее число {max}");
}
else 
{
    max = b;
    Console.WriteLine($"Наибольшее число {max}");
}