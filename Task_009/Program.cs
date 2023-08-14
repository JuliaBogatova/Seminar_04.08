﻿// Напишите программу, которая:

// 1. выводит случайное число из отрезка [10, 99] 
// 2. и показывает наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); //99+1
Console.WriteLine($"Случайное число в диапазоне 10 - 99 -> {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; //78 % 10 = 8

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");