// See Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да;7 -> да;1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели и проверьте, соответствует ли номер выходному дню: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());
if(numberDayOfWeek<1||numberDayOfWeek>7)
{
    Console.WriteLine("Введен несуществующий номер");
    return;
}

if(numberDayOfWeek<=5)
{
    Console.WriteLine("Нет.");
    return;
}
if(numberDayOfWeek<=7)
{
    Console.WriteLine("Да.");
}





