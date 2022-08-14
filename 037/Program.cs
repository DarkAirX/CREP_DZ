// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a = new int[7];
Random random = new Random();

for (int i = 0; i < a.Length; i++)

{
    a[i] = random.Next(100, 200);

}
int chet = 0;
    int nechet = 0;

  for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write(a[i] + " ");
        if (a[i] % 2 == 0) chet++;
        
        else nechet++; 
    
    }

    System.Console.WriteLine($"Количество четных чисел {chet}, количество нечетных чисел {nechet}");







/*for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) System.Console.WriteLine($"{ a[i]} Четный");
                
                    else
    System.Console.WriteLine($"{ a[i]} Нечетное");

            }
          */