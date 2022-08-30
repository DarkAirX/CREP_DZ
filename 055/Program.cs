// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов
int n = 4;
int m = 4;


int[,] matrix = Create2DArray(n, m);
PrintMatrix(matrix);
int[] Summ = GetSumm(matrix);
Printa(Summ);


//1 способ вернуть массив
int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];//создаем массив
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
        {
            a[i, j] = new Random().Next(0, 100);
        }
    }
    return a;
}

void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] >= 10) System.Console.Write($" {a[i, j]}  ");
            else System.Console.Write($"  {a[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[] GetSumm(int[,] a)
{
    int[] result = new int[a.GetLength(1)];
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum += a[i, j];//сумма элементов
            result[j] = sum / a.GetLength(1);
        }
    }
    return result;
}

void Printa(int[] a)
{
    System.Console.WriteLine();
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i]}  ");
    }
}

