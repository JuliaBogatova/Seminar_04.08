// Напишите программу, которая:
// 1. будет принимать на вход два числа и
// 2. выводить, является ли первое число кратным второму. 
// 3. Если первое число не кратно второму, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder(int first, int second)
{
    return first % second;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(firstNumber, secondNumber);
// if (remainder == 0)
//     Console.WriteLine($"{firstNumber} кратно {secondNumber}");
// else
//     Console.WriteLine($"{firstNumber} не кратно {secondNumber}. Остаток = {remainder}.");

Console.WriteLine(remainder == 0 ? $"{firstNumber} кратно {secondNumber}" : $"{firstNumber} не кратно {secondNumber}. Остаток = {remainder}.");
