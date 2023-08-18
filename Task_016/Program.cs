// Напишите программу, которая:
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

bool CheckSquareTwoNumbers(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquareTwoNumbers(firstNumber, secondNumber);
Console.WriteLine(result ? "Да" : "Нет.");