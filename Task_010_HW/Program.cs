// Напишите программу, которая:
// 1. принимает на вход трёхзначное число 
// 2. и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;

if (number < 100 || number > 999)
{
    Console.WriteLine("Ошибка! Введено не трехзначное число. Повторите попытку.");
    return;
}

int showSecondDigit = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра -> {showSecondDigit}");

int ShowSecondDigit(int num)
{
    int remainder = num % 100;
    int result = remainder / 10;
    return result;
}
