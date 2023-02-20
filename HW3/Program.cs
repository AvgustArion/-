// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
if ( day > 7)
{
    Console.WriteLine("Ввели не день недели!!!");
}
else if (day <= 5)
{
    Console.WriteLine($"День {day}: не выходной.");
}
else 
{
    Console.WriteLine($"День {day}: выходной.");
}