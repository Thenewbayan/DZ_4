// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// сделвем через деление и остатки, число вводит пользователь

Console.WriteLine("Введите любое натуральное число");
int number=Convert.ToInt32(Console.ReadLine());
//узнаем разрядность числа, для этого делим его на 10 в степени
int digit=0;
int summ=0;
while(number/(int) (Math.Pow(10, digit))!=0)
{
    summ+=(number/(int)(Math.Pow(10, digit))%10);
    digit+=1;
}
Console.WriteLine(summ);