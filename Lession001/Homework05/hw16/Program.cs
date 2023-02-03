//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Введите размер массива = ");
int x = Convert.ToInt32(Console.ReadLine());
double[] array = new double[x];
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write($"{array[i]}, ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
           max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"всего {x} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

