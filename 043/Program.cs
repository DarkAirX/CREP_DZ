// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры


int numbers = 5;
int count = 0;

while (numbers > 0)
{
    System.Console.WriteLine("Введите число: ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if(number > 0) count++;
    numbers--;
}
System.Console.WriteLine($"Количество чисел больше 0 = {count}");