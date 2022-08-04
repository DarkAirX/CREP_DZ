//Задать массив из 8 целых элементов и вывести их на экран
int N = 8;
int[] a = new int[N];
Random random = new Random();//псевдослучайные числа
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0, 11);




for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],4}");










/*//значимые типы (value types)
int a=3;
double b=4;
float c;
bool bl;
c=3.14F;
//ссылочные типы (reference types)
string s=null;
s="Hellowsadfsadfasdfasdf";
string s1=s;
int[] ar;
Random random;
random=new Random();
Random random1;
random1=random;
ar=new int[20000];
int[] ar2;
ar2=ar;
*/