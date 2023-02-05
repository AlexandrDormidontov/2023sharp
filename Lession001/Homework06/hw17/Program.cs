//Задача 41: Пользователь вводит 
//с клавиатуры M чисел. 
//Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


string s1 = "Hello ";
string s2 = "World";

int[] nums = {1, 2, 3, 4, 5};

string s3 = s1 + " " + s2;
Console.WriteLine(s3);
string s4 = string.Concat(s1, s2);
Console.WriteLine(s4);
string s5 = string.Join(" ", nums);
Console.WriteLine(s5);


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

