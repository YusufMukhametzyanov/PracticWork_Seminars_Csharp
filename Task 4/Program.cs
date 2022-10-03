/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
    Console.Write($"{a} максимальное число");
else if (b > c && b > a)
    Console.Write($"{b} максимальное число");
else if (c > a && c > b)
    Console.Write($"{c} максимальное число");
else if (c == a || c == b)
    Console.Write($"{c} максимальное число");
else if (b == a)
    Console.Write($"{a} максимальное число");

