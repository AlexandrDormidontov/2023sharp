//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет 
//местами первую и последнюю строку массива.

Console.WriteLine("Масив чисел: ");
int[,] num = new int[3, 4];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(0, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        int string0 = num[i, j];
        num[i, j] = num[2, j];
        num[2, j] = string0;
    }
}

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}

