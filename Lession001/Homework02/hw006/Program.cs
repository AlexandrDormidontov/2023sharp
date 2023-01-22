//Задача 13: 
//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    int num = (int)Math.Floor(Math.Log10(number))-2;
    int num2 = (int)Math.Pow(10, num);
    Console.WriteLine((number / num2 % 10) % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

//второй вариант решения задачи
//Console.WriteLine("Введите число: ");
//int a = Convert.ToInt32(Console.ReadLine());
//int e = 10;
//if (a > 99)
//{
//  while (a >999)
//  {
//    a = a/e;
//  }  
//}
//result = a% e;
//Console.WriteLine($"Третье число: {result}");