//String s = "Hello World";
//Console.WriteLine(s[6]);

//Выдаст символ под шестым индексом 

//string s = "Hello World";
//string s1 = "Hello ";
//string s2 = "World";

//string s3 = s1 + s2;

//Console.WriteLine(s3);// выведет текст Hello World

//String s = "Hello World";
//String s1 = "Hello ";
//String s2 = "World";

//string s3 = s1 + s2;
//string s3 = string.Concat( s1, s2);//та же самая запись что выше строчкой
//Console.WriteLine(s3);

//знакомство с Join
//string s = "Hello World";
//string s1 = "Hello ";
//string s2 = "World";

//int[] nums = {1, 2, 3, 4, 5};

//string s3 = s1 + " " + s2;

//string s4 = string.Concat(s1, s2);

//string s5 = string.Join(" ", nums);
//Console.WriteLine(s5);


//string s = "1, 2, 3, 4, 5, 6, 7"; это с циклом foreach
//foreach (var item in s)
//{
//    Console.WriteLine(item);
//}
//расссмотрим цикл Split. он выполняет обратный процесс

//string s = "1, 2, 3, 4, 5, 6, 7";
//
//string[] nums = s.Split(' ');
//foreach (var item in nums)
//{
//   Console.WriteLine(item);
//}
//на выходе мы увидим столбик из цифр с запятыми

//string s = "1, 2, 3, 4, 5, 6, 7";

//string[] nums = s.Split(' ', ',', '.');
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
//на выходе мы увидим столбик из цифр без запятых и точек , но спропусками между строк

//string s = "1, 2, 3, 4, 5, 6, 7";

//string[] nums = s.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
// получили массив строк и будем переводить его в массив целых чисел

//string s = "1, 2, 3, 4, 5, 6, 7";

//string[] nums = s.Split(new char[]{' ', ',', '.'} , StringSplitOptions.RemoveEmptyEntries);

//int[] n = nums.Select(Int32.Parse).ToArray();


//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//string s1 = "10 21 35 45 57 68 79";
//int[] num1 = Array.ConvertAll(s1.Split(), int.Parse);//это такая же запись что и выше в оптимизированнном виде
//Console.WriteLine(s1);
//ToArray() метод позволяет изменить последовательность  из одного типа в другой
//Select это операция позволяет создать какую либо выходную последовательность


//Задача 31: Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] num = new int[12];
int sumpol = 0;
int sumotr = 0;
for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(-9, 9);

}
foreach (var n in num)
{
    Console.Write($"{n}  ");
}
for (int i = 0; i < num.Length; i++)
{
    if (num[i] >= 0)
    {
        sumpol = sumpol + num[i];
    }
    else
    {
        sumotr = sumotr + num[i];
    }
}
Console.WriteLine();
Console.WriteLine($"сумма положительных чисел {sumpol}");
Console.Write($"сумма отрицательных чисел {sumotr}");