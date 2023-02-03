//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
int[] num = new int[x];

for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(100, 1000);

int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
       if (num[i] % 2 == 0)
       {
        result++;
       } 
    } 
   foreach (int n in num)
{
Console.Write($"{n} ");
}
Console.Write("  -> это массив из положительных трехзначных чисел    ");

Console.Write($"Число четных чисел: {result}");

