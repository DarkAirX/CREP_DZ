﻿// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

int a = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(a)>=100)
{
System.Console.WriteLine(a/100%10);
}
else
{
    System.Console.WriteLine("Число имеет меньше трех цифр");
}