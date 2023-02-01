// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write ("Введите число: ");

string number = Console.ReadLine();

if (number.Length<3)
{
    Console.WriteLine ("Третьей цифры нет");
    return;
}

string number2 = Convert.ToString(number[2]);
  
Console.WriteLine ($"3 цифра = {number2 }");

