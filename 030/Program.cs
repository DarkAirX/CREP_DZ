// Написать программу вычисления произведения чисел от 1 до N
System.Console.WriteLine("введите число ");
string writeA = System.Console.ReadLine();
int A = Convert.ToInt32(writeA);

int multNumber(int A)
{
    int number = A;
    int sum = 1;
    for (int i=0; i < A; i++)
    {
        sum = sum * number;
        number++;
}
return sum;
}

int NumbersMult = multNumber(A);
System.Console.WriteLine($"Произведение чисел от 1 до {A} = {NumbersMult}");