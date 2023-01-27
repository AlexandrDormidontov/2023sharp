//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Write($"Введите желаемое количество чисел в массиве: ");
int A = Convert.ToInt32(Console.ReadLine());

int[] array = new int[A];
Console.WriteLine($"числа в массиве = ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($" {array[i]}, ");
}
