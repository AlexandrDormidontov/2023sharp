//22) Напишите программу, 
//которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел 
//от 1 до N.
//
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4



//Console.WriteLine("Введите положительное число: ");
//int N = Convert.ToInt32(Console.ReadLine());

//Console.Write($"{N} ->  ");
//for (int i = 1; i <= N; i++)
//{
//   Console.Write($"{Math.Pow(i, 2)}, ");
//}

//решение задачт с помощью массива, 
Console.WriteLine("Введите положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N] ;
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Math.Pow((i + 1), 2));
}
foreach (var c in array)
{
    Console.Write($"{c} ");
}


