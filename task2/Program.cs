// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int max = 0;
if (num1 > max)
{
    max = num1;
}
else if (num2 > num1)
{
    max = num2;
}
else max = num3;


Console.WriteLine($"{max} - максимальное из введённых чисел");