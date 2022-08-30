// Написать программу, которая обменивает элементы первой строки и последней строки
int n = 4;
int m = 4;


int[,] matrix = GetMatrix(n, m);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] matrix2 = Switch(matrix);
PrintMatrix(matrix2);



//1 способ вернуть массив
int[,] GetMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

int[,] Switch(int[,] a)
{
    for (int i = 0; i < a.GetLength(1); i++)
    {
        int value = a[0, i];
        a[0, i] = a[a.GetLength(0) - 1, i];
        a[a.GetLength(0) - 1, i] = value;
    }
    return a;
}

void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write(a[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

