﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Большее из введённых двух чисел {num1}");
}
else Console.WriteLine($"Большее из введённых двух чисел {num2}");
