// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Возведем число в степень. Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень для числа");
int deegre = Convert.ToInt32(Console.ReadLine());
int result=1;
for (int i=1; i<=deegre; i++)
{
    result*=number;
} 
Console.WriteLine($" Число {number}  в степени {deegre} :{result}");