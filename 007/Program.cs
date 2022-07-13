// Выяснить является ли число чётным.
double a;
string? s = Console.ReadLine();
a=Convert.ToDouble(s);
if ((a % 2) == 0)
{
    System.Console.WriteLine("четное");
}
else
{
    System.Console.WriteLine("нечетное");
}