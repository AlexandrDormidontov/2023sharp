//Задача 33: Задайте массив. 
//Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 101);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] == num)
    {
        Console.WriteLine("Да, такое число есть в массиве.");
        count++;
        break;
    }
}
if (count == 0)
{
   Console.WriteLine("Нет такого числа в массиве"); 
}

