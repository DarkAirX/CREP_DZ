// написать программу вывода чисел от 1 до N без использования циклов и оператора

void loop (int i,int N)
{
    System.Console.WriteLine(i);
    if(i<N) loop(i+1,N);//рекурсия
}
loop(1,10);