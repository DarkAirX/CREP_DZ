// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


  int c = 0;
            Random Rand = new Random();
            int[] a = new int[4];
            Console.WriteLine("");


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Rand.Next(100, 300);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");

 for (int i = 0; i < a.Length; i++)
 

            {
                if ((a[i] % 10) % 2 == 0)
                {
                    c++;
                }
              
            }
            Console.WriteLine("Количество четных цифр: {0}", c);
                        
               
        
      