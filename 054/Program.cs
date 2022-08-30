// Написать подпрограмму, которая в матрице чисел находит сумму элементов главной диагонали

int[,] arr;
arr=Create2DArray(3,3);
Print(arr);
 System.Console.WriteLine($"сумма элементов главной диагонали {SumMain(arr)}");


   
    
//1 способ вернуть массив
int[,] Create2DArray(int n,int m)
{
    int[,] a=new int[n,m];//создаем массив
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
        for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
            a[i,j]=random.Next(0,100);
    return a;
}

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
    {
            for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
                System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
    }

}
int SumMain(int[,] arr)
{
    int sum=0;
    for (int i = 0; i < arr.GetLength(0); i++) 
    sum=sum+arr[i,i]; //сумма элементов главной диагонали
    return sum;  
    }
    
/*сумма элементов побочной диагонали
    int SumMain(int[,] arr)
{
    int sum=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    sum=sum+arr[i,(arr.GetLength(0)-i-1)];
    return sum;  
    }
*/
