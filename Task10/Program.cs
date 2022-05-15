// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = 1;
while (number < 100 || number > 1000)
{
    Console.WriteLine("Введите трехзначное число");
    number = Convert.ToInt32(Console.ReadLine());
}
number = (number / 10) % 10;
Console.Write("Второе число ");
Console.Write(number);
