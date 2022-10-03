/* Напишите программу, которая на входе будет принимать трёхзначное число и на выходе показывает последнюю цифру этого числа
456 -> 6    782 -> 2    918 -> 8 */

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 1000 && number>99)
{
    Console.WriteLine(number%10);
}
else 
    Console.WriteLine("Введено не трёхзначное число");

