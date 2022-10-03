/* Написать программу, которая будет выдавать название дня недели по заданному номеру 

Console.Write("Введите номер дня недели: ");
string a = Console.ReadLine();

int a1 = int.Parse(a);

if (a1 == 1)
    Console.Write($"{a1} -> понедельник");
if (a1 == 2)
    Console.WriteLine($"{a1} -> вторник");
if (a1 == 3)
    Console.WriteLine($"{a1} -> среда");
if (a1 == 4)
    Console.WriteLine($"{a1} -> четверг");
if (a1 == 5)
    Console.WriteLine($"{a1} -> пятница");
if (a1 == 6)
    Console.WriteLine($"{a1} -> суббота");
if (a1 == 7)
    Console.WriteLine($"{a1} -> воскресение"); */

Console.Write("Enter day of the week: ");
string a = Console.ReadLine();

if (a == "1")
    Console.WriteLine("1 -> Понедельник");
else if (a == "2")
    Console.WriteLine("2 -> Вторник");
else if (a == "3")
    Console.WriteLine("3 -> Среда");
else if (a == "4")
    Console.WriteLine("4 -> Четверг");
else if (a == "5")
    Console.WriteLine("5 -> Пятница");
else if (a == "6")
    Console.WriteLine("6 -> Суббота");
else if (a == "7")
    Console.WriteLine("7 -> Воскресенье");

else
Console.WriteLine("Вы ввели не верное число");

