// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите трёхзначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = number % 10;
if (number < 100) 
{
    Console.Write("Ввели не трёхзначное число");
} else 
{
    Console.WriteLine(sum);
}