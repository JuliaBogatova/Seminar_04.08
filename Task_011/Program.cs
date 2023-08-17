// Напишите программу:
// 1. которая выводит случайное трёхзначное число 
// 2. и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число в диапазоне 100 - 999 -> {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"Результат после удаления второй цифры: {result}");

int deleteSecondDigit = DeleteSecondDigitt(number);
Console.WriteLine($"Результат после удаления второй цифры: {deleteSecondDigit}");

int DeleteSecondDigitt(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}