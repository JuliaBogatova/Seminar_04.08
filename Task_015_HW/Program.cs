// Напишите программу, которая:
// 1. принимает на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckDayOff(int num)
{
    return num > 5 && num <= 7;
}

Console.WriteLine("1 -> Понедельник");
Console.WriteLine("2 -> Вторник");
Console.WriteLine("3 -> Среда");
Console.WriteLine("4 -> Четверг");
Console.WriteLine("5 -> Пятница");
Console.WriteLine("6 -> Суббота");
Console.WriteLine("7 -> Воскресенье");
Console.WriteLine("");

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1 || number > 7)
{
    Console.Write("Введен неверный номер. Повторите ввод. ");
    return;
}

bool result = CheckDayOff(number);
Console.WriteLine(result ? "Да, является выходным." : "Нет, не является выходным.");