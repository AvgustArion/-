// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = number % 2;
if (sum == 0)
{
    Console.WriteLine($"Число: {number} - чётное.");
}
else
{
    Console.WriteLine($"Число: {number} - не чётное.");
}