// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
bool s=a%b==0;
if (s)
    {
    System.Console.WriteLine("Кратно");
    }
   else
{

            Console.WriteLine("Результат и остаток от деления a на b: {0} __ {1}",a / b, a % b);
       
}
    
