// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число дня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());
if(Number <= 7 & Number >= 1)

{
    if(Number == 1)
    {
        Console.Write(" Понедельник ");
    }
    if(Number == 2)
    {
        Console.Write(" Вторник ");
    }
    if(Number == 3)
    {
        Console.Write(" Среда ");
    }
    if(Number == 4)
    {
        Console.Write(" Четверг ");
    }
    if(Number == 5)
    {
        Console.Write(" Пятница ");
    }
    if(Number == 6)
    {
        Console.Write(" Суббота ");
    }
    if(Number == 7)
    {
        Console.Write(" Воскресенье ");
    }
}
else
{
    Console.WriteLine(" Такого дня недели не существует ");
}
if (Number == 6 || Number == 7)
{
     System.Console.WriteLine(" - Это Выходной ");
}

