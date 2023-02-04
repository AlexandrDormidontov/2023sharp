//Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся 
//на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 
//1+9+2 = 12

Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
int temp = 0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
        if ( i == j)
        {
            temp = temp + num[i,j];
        }
    }
    Console.WriteLine();
    
}
Console.WriteLine(temp);