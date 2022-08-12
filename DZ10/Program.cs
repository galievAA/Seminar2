// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введи трёхзначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(i);

System.Console.WriteLine("Вторая цифра этого числа -> "+ Number[1]);




