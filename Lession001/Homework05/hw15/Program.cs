//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
int[] num = new int[x];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(-100, 101);
foreach (int n in num)
{
    Console.Write($"{n} ");
}
Console.Write("  -> это предложенный массив чисел    ");

int sum = 0;
for (int i = 0; i < num.Length; i += 2)
{
    sum = sum + num[i];
}
Console.WriteLine();
Console.WriteLine($"весь массив состоит из {x} цифр, сумма элементов cтоящих на нечётных позициях = {sum}");


