// Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа

int a=76;
int d1=a/10;
int d2=a%10;
int result=Math.Max(d1,d2);
System.Console.WriteLine(result);