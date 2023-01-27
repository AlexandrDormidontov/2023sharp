
//void SayLang()
//{
 // Console.WriteLine("привет мир");  
//}

//SayLang();

//SayLang();

//void SayLang(string lang)
//{
//  Console.WriteLine("привет, {lang}");  
//}
//string lang1 = "javascript";
//SayLang (string1);
//
//SayLang("PHP");
//SayLang("werty");

//int NumSum(int numA, int numB) //формирование метода нахождения суммы 2х чисел
//{
//    int result = numA + numB;
//    return result;
//}

//int x = NumSum(3,7);
///Console.WriteLine(x);

//int y = NumSum (2,6);
//Console.WriteLine(y);

int SumNum(int numA, int numB) //описание метода SumNum 
//(метод всегда начинается с заглавной буквы и желательно чтобы присутствовал глагол)
{
    if (numA >numB)
    {
        int result = numA - numB;
        return result;
    }
    else
    {
        int result = numB - numA;
        return result;
    }  
}
int x = SumNum(3, 2);
Console.WriteLine(x);

int y = SumNum(4, 7);
Console.WriteLine(y);

Console.WriteLine(SumNum(19, 24));
