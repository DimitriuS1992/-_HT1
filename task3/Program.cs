// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)

    Console.WriteLine($"{num} - чётное число");

else

   Console.WriteLine($"{num} - не является чётныи числом");
