//методы разные 
/*void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*
// Создаем метод для ввода числа пользователем

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

// Создаем метод заполнения двумерного массива

int [,] SetArray2D (int line, int column)
{
    int [,] numArr2D = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (0, 10);
        }
    }
    return numArr2D;
}

// Создаем метод вывода двумерного массива

void PrintArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

// Создаем метод замены местами первой и последней строки

int [,] SortArr2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            for (int a = 0; a < array2D.GetLength (1); a++)
            {
                if (array2D [i, a] < array2D [i, j])
                {
                    int temp = array2D [i, j];
                    array2D [i, j] = array2D [i, a];
                    array2D [i, a] = temp;
                }
            }
        }
    }
    return array2D;
}
*/
