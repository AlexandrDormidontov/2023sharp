//Задача 55: Задайте двумерный массив. 
//Напишите программу, которая заменяет 
//строки на столбцы. В случае, 
//если это невозможно, программа 
//должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строк в массиве:  ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:  ");
int columns = Convert.ToInt32(Console.ReadLine());
Random arr = new Random();
int[,] array = new int[arr.Next(1, 10), arr.Next(1, 10)];

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
       
    }
}
 Console.WriteLine();

/*
int lines = new Random().Next(1, lines);
int columns = new Random().Next(1, columns);
int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//int[,] array = new int[lines, columns];
if (array.GetLength(0) == array.GetLength(1))
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
                
            }
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Поменять строки и столбцы невозможно");
*/





/*
Console.WriteLine("Введите количество строк в массиве:  ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:  ");
int columns = Convert.ToInt32(Console.ReadLine());

int lines = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);

//int arrayLastLine = GetLength(1) - 1;
//PrintArray(lines, columns);

int[,] array = new int[lines, columns];
if (array.GetLength(0) == array.GetLength(1))
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
                
            }
        }
    }
    //Console.WriteLine(lines, columns);
}
Console.WriteLine("Поменять строки и столбцы невозможно");
*/
//Задача 57: Составить частотный 
//словарь элементов двумерного массива. 
//Частотный словарь содержит информацию 
//о том, сколько раз встречается 
//элемент входных данных.

//Набор данных
//Частотный массив
//{ 1, 9, 9, 0, 2, 8, 0, 9 }
//0 встречается 2 раза 
//1 встречается 1 раз 
//2 встречается 1 раз 
//8 встречается 1 раз 
//9 встречается 3 раза
//1, 2, 3 
//4, 6, 1 
//2, 1, 6
//1 встречается 3 раза 
//2 встречается 2 раз 
//3 встречается 1 раз 
//4 встречается 1 раз 
//6 встречается 2 раза

//Задача 59: Задайте двумерный массив 
//из целых чисел. 
//Напишите программу, которая 
//удалит строку и столбец, 
//на пересечении которых 
//расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, 
//на выходе получим 
//следующий массив:
//9 4 2
//2 2 6
//3 4 7


//Задача 61: Вывести первые N строк 
//треугольника Паскаля. 
//Сделать вывод в виде равнобедренного 
//треугольника
