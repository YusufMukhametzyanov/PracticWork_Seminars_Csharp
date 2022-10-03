/*Напишите программу, которая на входе принимает число и на выходе выдаёт его квадрат*/

Console.Write("Введите число: ");
string numberStr = Console.ReadLine();

int number = int.Parse(numberStr);
int result = number * number;

Console.Write($"квадратом числа {number} является {result}");