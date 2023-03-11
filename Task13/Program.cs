// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int thirdDigit(int num)
{
    while(num > 999)
    {
        num /= 10;
    }
    return num % 10;
}
bool check(int num)
{
    if (num<100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;



}
int num = new Random().Next();
int rsd = thirdDigit(num);
Console.WriteLine($"Случайное число -> {num}");

if (check(num))
{
    Console.WriteLine($"Число -> {rsd}");
}

