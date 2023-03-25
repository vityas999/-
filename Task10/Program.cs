// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int secondDigit(int num)
{
int thirdDigit = num % 100;
int result = thirdDigit / 10;
return result;
}
int number = new Random().Next(100,1000);
int rsd = secondDigit(number);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
Console.WriteLine($"Число -> {rsd}");
