// Ctrl + K + C = Добавить комментраний
// Ctrl + K + U = Удалить комментраний

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число и я выведу вам вторую цифру этого числа");
Console.Write(": ");
if (!int.TryParse(Console.ReadLine(), out int number) || number < 100 || number > 999)
{
  Console.Write("Неправильный ввод данных! Введите трёхзначное число: ");
  return;
}
int newnumber = number / 10;
int secondDigit = newnumber % 10;
Console.WriteLine("Вторая цифра числа " + number + " это " + secondDigit); 
Console.ReadKey();
