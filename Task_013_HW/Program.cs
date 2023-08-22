// Напишите программу, которая:
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ShowThirdDigit(int num)
{
    int result = num % 10;
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;

while (number > 999)
    {
        number = number / 10;
    }
if (number < 100)
{
    Console.WriteLine("В числе нет третьей цифры. Введите другое число.");
    return;
}
int showThirdDigit = ShowThirdDigit(number);
Console.WriteLine($"Третья цифра -> {showThirdDigit}");

