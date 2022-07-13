// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//метод

//Console.WriteLine((2+2)*(2/2-2%2));

//Объявление переменных
//int a,b=0
//double c;
//string s;
/* Многострочный комментарий
int a=2, b=3;//Операция присваивания
int s=a+b;
Console.WriteLine(a+"+"+b+"="+s);
System.Console.WriteLine("{0}+{1}={2}",a,b,s);//строка форматирования
System.Console.WriteLine($"{a}+{b}={s}");//строка интерполяции
*/

//Вести с клаиатуры целое число и вывести квадрат этого числа на экран 
double a;
double b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");