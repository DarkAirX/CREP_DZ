// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int N = Convert.ToInt32(Console.ReadLine());
int Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);

}

for (int i = 1; i < N; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}