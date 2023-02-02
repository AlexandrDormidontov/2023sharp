//Задача 32: Напишите программу замены элементов массива:
//положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 


Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());         //вводим длину массива
int[] num = new int[x];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(-9, 10);             //создаем массив
foreach (int n in num)             // прогоняем массив по индексам
{
    Console.Write($"{n} ");
}
Console.Write("  -> это изначальный массив"); //выводим массив на экран
for (int i = 0; i < num.Length; i++)     //прогоняем массив через умножение на мину единицу
    num[i] *= (-1);
Console.WriteLine();
foreach (int n in num)   //снова выводим массив
{
    Console.Write($"{n} ");
}
Console.Write("  -> это измененный массив");