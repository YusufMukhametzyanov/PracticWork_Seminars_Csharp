Console.Write("Введите число N");
int number = int.Parse(Console.ReadLine());

for (int i = -number; i <= number; i++)

{
    Console.Write($" {i}");
}