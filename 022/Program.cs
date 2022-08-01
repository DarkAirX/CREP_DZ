// Программа проверяет пятизначное число на палиндромом

System.Console.WriteLine("Введите число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  

bool Palind()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

System.Console.WriteLine("");
if (Palind()) System.Console.WriteLine($"1. Это число - {number} - является палиндромом");
else System.Console.WriteLine($"1. Число {number} не является палиндромом");
System.Console.WriteLine();
