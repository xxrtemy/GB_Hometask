﻿
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine(sum);