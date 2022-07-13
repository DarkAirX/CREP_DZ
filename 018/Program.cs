// По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

bool check(int a, int b)
{
    return a*a==b || b*b==a;
}

int a = 3;
int b = 9;
if (check(a,b))
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не яввляется");
}