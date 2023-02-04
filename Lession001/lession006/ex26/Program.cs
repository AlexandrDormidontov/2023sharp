//Задача 42: Напишите программу, 
//которая будет преобразовывать 
//десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
//первый вариант через строки
Console.WriteLine("Введите число для преобразования: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = "";
while (num > 0)
{
    result = Convert.ToString(num % 2) + result; //добавляя result  в конце мы пишем число справа налево 
    num /= 2;
}
Console.WriteLine(result);

//попытка решить вторым способом

//int[] ConverterToBinary(int num)
//{
//    int[] result = new int[num];
//    int i = 0;
//    result[i] = 0;
//    while (num > 0)
//    {
//        result[i] = num % 2;
        
//        num = num / 2;
//        i = i + 1;
//    }
    //result.Reverse();  //возвращает массив в обратном порядке
//    foreach (var item in result.Reverse())
//    {
//        Console.Write(item);
//    }
//    return result;
//}
//Console.WriteLine("Введите число для преобразования: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.Write($" число {num} будет -> {ConverterToBinary(num)} ");
