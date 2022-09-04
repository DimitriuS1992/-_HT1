//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine($"{num1} наибольшее из двух числе, а {num2} наименьшее");
else
    Console.WriteLine($"{num2} наибольшее из двух числе, а {num1} наименьшее");
