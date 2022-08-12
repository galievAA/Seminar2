// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Вводим число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string i = Convert.ToString(Number);

if (i.Length > 2)
{
  System.Console.WriteLine("Третья цифра -> " + i[2]);
}
else 
{
  System.Console.WriteLine("-> Отсутсвует число");
}

