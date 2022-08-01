// Подсчитать сумму цифр в числе
System.Console.WriteLine();

int number = new Random().Next(1, 10000);
int sum = 0;
System.Console.Write($" {number} ");
while (number > 0)
{
    int sums = number % 10;
    sum = sum + sums;
    number = number / 10;
}

int SumNumbers = number;
System.Console.Write($" Сумма цифр числа равна {SumNumbers} "); 



System.Console.WriteLine(sum);