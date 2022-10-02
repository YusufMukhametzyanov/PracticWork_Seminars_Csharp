/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. */

Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
Console.WriteLine("Введите второе число");
string b = Console.ReadLine();

int c = int.Parse(a);
int d = int.Parse(b);

if (c == d * d)
    Console.WriteLine($"Число {c} является квадратом {d}");
else
    Console.WriteLine($"Число {c} не является квадратом {d}");

