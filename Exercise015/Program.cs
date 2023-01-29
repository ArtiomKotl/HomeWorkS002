// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели и проверим, является ли этот день выходным.");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
  if (number == 6 || number == 7)
    Console.WriteLine("ДА, это выходной день.");
  else
    Console.WriteLine("Нет, это будний день.");
}
else
{
  Console.WriteLine("Это не день недели.");
}
Console.ReadKey();