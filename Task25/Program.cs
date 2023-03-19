// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//Console.WriteLine($"Число {numberA} в натурольной степени {numberB} = " + Math.Pow(numberA, numberB));

Console.WriteLine("Введите число, которое хотите возвести в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = naturalDegree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");

int naturalDegree(int numbA, int numbB)
{
    int sum = 1;
    for(int i = 0; i < numbB; i++) 
    {
        sum  *= numbA;
    }
    return sum;
}
