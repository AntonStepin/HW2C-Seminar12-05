// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Напишите номер дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber > 0 && DayNumber < 6)
{
    Console.WriteLine("Будний день");
}
else if (DayNumber > 5 && DayNumber < 8)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Такого дня не существует");
}