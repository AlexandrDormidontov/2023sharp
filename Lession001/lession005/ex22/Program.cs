Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 



Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
int[] num = new int[x];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(-9, 10);
foreach (int n in num)
{
    Console.Write($"{n} ");
}
Console.Write("  -> это изначальный массив");
for (int i = 0; i < num.Length; i++)
    num[i] *= (-1);
Console.WriteLine();
foreach (int n in num)
{
    Console.Write($"{n} ");
}
Console.Write("  -> это измененный массив");