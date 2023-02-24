﻿/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else 
        {
            Console.WriteLine("Ввели не число!");
        }
    }

    return result;
}

int k = GetNumber("Введите число");
for ( int i = 1; i <= k; i ++)
{
    Console.Write($"{Math.Pow(i,3)}, ");
}