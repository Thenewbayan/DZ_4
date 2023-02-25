// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Создадим массив из нескольких случайных  чисел, например 8");
Console.WriteLine("Вам нужно указать нижнюю границу и верхнюю границу через кнопку enter");
int minValue=Convert.ToInt32(Console.ReadLine());
int maxValue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите сколько случайных чисел вы хотите получить");
int size=Convert.ToInt32(Console.ReadLine());
int [] array=new int [size];
for (int i=0; i<size; i++)
{
    array[i]=new Random().Next(minValue, maxValue+1);
}
Console.WriteLine(String.Join(";", array));