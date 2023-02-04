//Задача 49: 
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
//замените эти элементы на их квадраты.
//Например, изначально массив
// выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4

Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            num[i, j] = num[i, j] * num[i, j];
            Console.Write($"{num[i, j]} ");
        }
        else
        {
            num[i, j] = num[i, j];
            Console.Write($"{num[i, j]} ");
        }
    }
    Console.WriteLine();
}