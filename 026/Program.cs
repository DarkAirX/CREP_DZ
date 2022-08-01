// Найти сумму чисел от 1 до А
System.Console.WriteLine("введите число ");
string writeA = System.Console.ReadLine();
int A = Convert.ToInt32(writeA);

int sumNumbers(int A)
{
    int number = A;
    int sum = 0;
    for (int i=0; i < A; i++)
    {
        sum = sum + number;
        number++;
}
return sum;
}

int NumbersSum = sumNumbers(A);
System.Console.WriteLine($"Сумма чисел от 1 до {A} = {NumbersSum}");